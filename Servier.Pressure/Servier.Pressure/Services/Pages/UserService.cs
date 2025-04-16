using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Servier.Pressure.Data;
using System.Text.Encodings.Web;
using System.Text;

namespace Servier.Pressure.Services.Pages;

public class UserService(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, NavigationManager navigationManager, IUserStore<ApplicationUser> userStore,
    IEmailSender<ApplicationUser> emailSender, ApplicationDbContext context, ILogger<UserService> logger)
{
    private readonly UserManager<ApplicationUser> _userManager = userManager;
    private readonly RoleManager<IdentityRole> _roleManager = roleManager;
    private readonly NavigationManager _navigationManager = navigationManager;
    private readonly IUserStore<ApplicationUser> _userStore = userStore;
    private readonly IEmailSender<ApplicationUser> _emailSender = emailSender;
    private readonly ApplicationDbContext _context = context;
    private readonly ILogger _logger = logger;

    public async Task<List<ApplicationUser>> GetUsersAsync()
    {
        // read all users
        var users = await _userManager.Users.ToListAsync();
        // read all roles
        var roles = await _roleManager.Roles.ToListAsync();
        // read all workplaces
        var workplaces = await _context.WorkPlaces.ToListAsync();
        // for each user read and assign role and workplace
        foreach (var user in users)
        {
            // role
            var userRoles = await _userManager.GetRolesAsync(user);
            if (userRoles == null || userRoles.Count == 0)
            {
                user.Role = roles.FirstOrDefault(i => i.Name == "Doctor");
                await AddUserToRoleAsync(user);
                userRoles = await _userManager.GetRolesAsync(user);
            }
            user.Role = roles.FirstOrDefault(i => i.Name == userRoles.First());
        }
        return users;
    }

    public async Task<List<IdentityRole>> GetRolesAsync()
    {
        return await _roleManager.Roles.ToListAsync();
    }

    public async Task<ApplicationUser?> GetUserByIdAsync(string userId)
    {
        return await _userManager.FindByIdAsync(userId);
    }

    public async Task<IdentityResult> CreateUserAsync(ApplicationUser user)
    {
        // prepare user to store
        var dummyUser = CreateUser();

        await _userStore.SetUserNameAsync(dummyUser, user.UserName, CancellationToken.None);
        var emailStore = GetEmailStore();
        await emailStore.SetEmailAsync(dummyUser, user.UserName, CancellationToken.None);
        dummyUser.FirstName = user.FirstName;
        dummyUser.LastName = user.LastName;
        dummyUser.TitleBefore = user.TitleBefore;
        dummyUser.TitleAfter = user.TitleAfter;
        dummyUser.Code = user.Code;
        dummyUser.PhoneNumber = user.PhoneNumber;
        dummyUser.Role = user.Role;

        // create user
        var result = await _userManager.CreateAsync(dummyUser, user.Password!);
        if (result.Succeeded)
            _logger.LogInformation("User {UserName} successfully created.", user.UserName);
        else
        {
            _logger.LogError("Adding of user {UserName} failed.", user.UserName);
            foreach (var error in result.Errors)
                _logger.LogError("Detail: {error}", error.Description);
            return result;
        }

        // send confirmation email
        var userId = await _userManager.GetUserIdAsync(dummyUser);
        var code = await _userManager.GenerateEmailConfirmationTokenAsync(dummyUser);
        code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
        var callbackUrl = _navigationManager.GetUriWithQueryParameters(
            _navigationManager.ToAbsoluteUri("Account/ConfirmEmailRegister").AbsoluteUri,
            new Dictionary<string, object?> { ["userId"] = userId, ["code"] = code, ["returnUrl"] = @"/" });

        if (_emailSender is EmailSender eSender)
        {
            string body = string.Format("<!DOCTYPE html><html><body><p>Vážená pani doktorka/Vážený pán doktor,</p>" +
                "<p>pozývame Vás k účasti na projekte spoločnosti Servier Slovensko spol s.r.o., ktorý zahŕňa trojmesačnú, observačnú, epidemiologickú štúdiu zameranú " +
                "na hodnotenie kontroly krvného tlaku u pacientov s potvrdenou a liečenou artériovou hypertenziou.</p>" +
                "<p>Aby ste mohli začať využívať systém určený na zber a spracovanie údajov o pacientoch, postupujte podľa týchto krokov:</p>" +
                "<ol type='1'>" +
                    "<li>Overte svoju emailovú adresu kliknutím na nasledujúci <a href='{0}' style='color: blue; text-decoration: underline;'>odkaz</a>.</li>" +
                    "<p>Ak odkaz nefunguje, skopírujte a vložte nasledujúcu adresu do vášho webového prehliadača:</p>" +
                    "<p>{0}</p>" +
                    "<p>Odkaz je platný po obmedzený čas.</p>" +
                    "<li>Následne si na stránke zvoľte vlastné heslo.</li>" +
                    "<li>Po dokončení registrácie môžete ihneď začať pracovať so systémom.</li>" +
                "</ol>" +
                "<p>V prípade akýchkoľvek otázok alebo problémov s registráciou nás neváhajte kontaktovať na telefónnom čísle +421 948 634 336. Radi Vám pomôžeme.<br>" +
                "Ďakujeme za Vašu účasť a tešíme sa na spoluprácu.</p>" +
                "<p>S pozdravom,<br>Váš tím podpory</p></body></html>", HtmlEncoder.Default.Encode(callbackUrl));
            await eSender.SendEmailAsync(user.UserName!, "Pozvanka k ucasti na projekte DMTK 2025", body);
        }

        //await _emailSender.SendConfirmationLinkAsync(dummyUser, user.UserName!, HtmlEncoder.Default.Encode(callbackUrl));

        if (result.Succeeded)
        {
            var resultRole = await AddUserToRoleAsync(dummyUser);
            if (!resultRole.Succeeded)
                return resultRole;
        }

        return result;
    }

    public async Task<IdentityResult> AddUserToRoleAsync(ApplicationUser user)
    {
        // read and remove original role
        var userOrig = await GetUserByIdAsync(user.Id);
        if (userOrig != null)
        {
            var userRole = await _userManager.GetRolesAsync(userOrig);
            if (userRole != null && userRole.Count > 0)
            {
                var resultRemove = await _userManager.RemoveFromRoleAsync(userOrig, userRole.First());
                if (!resultRemove.Succeeded)
                {
                    _logger.LogError("Fail of removing user ({UserName}) from role {UserRole}.", user.UserName, userRole.First());
                    foreach (var error in resultRemove.Errors)
                        _logger.LogError("Detail: {error}", error.Description);
                    return resultRemove;
                }
            }
        }

        // add new role
        var resultAdd = await _userManager.AddToRoleAsync(userOrig!, user.Role!.Name!);
        if (resultAdd.Succeeded)
            _logger.LogInformation("Added user ({UserName}) to role {UserRole}.", user.UserName, user.Role!.Name!);
        else
        {
            _logger.LogError("Fail of adding user {UserName}  to role {UserRole}.", user.UserName, user.Role!.Name!);
            foreach (var error in resultAdd.Errors)
                _logger.LogError("Detail: {error}", error.Description);
        }
        return resultAdd;
    }

    public async Task<IdentityResult> UpdateUserAsync(ApplicationUser user)
    {
        IdentityResult? result = new();

        // get original database user
        var userOrig = await GetUserByIdAsync(user.Id);
        if (userOrig != null)
        {
            // change user properties
            userOrig.FirstName = user.FirstName;
            userOrig.LastName = user.LastName;
            userOrig.TitleBefore = user.TitleBefore;
            userOrig.TitleAfter = user.TitleAfter;
            userOrig.Code = user.Code;
            userOrig.LockoutEnabled = user.LockoutEnabled;
            userOrig.LockoutEnd = user.LockoutEnd;

            // update user in database
            result = await _userManager.UpdateAsync(userOrig);
            if (result.Succeeded)
                _logger.LogInformation("The user {UserName} has been successfully changed.", user.UserName);
            else
            {
                _logger.LogError("Could not change user {UserName}.", user.UserName);
                foreach (var error in result.Errors)
                    _logger.LogError("Detail: {error}", error.Description);
                return result;
            }
        }

        return result;
    }
    public async Task<IdentityResult> SetPhoneNumberAsync(ApplicationUser user)
    {
        var userOrig = await GetUserByIdAsync(user.Id);
        var result = await _userManager.SetPhoneNumberAsync(userOrig!, user.PhoneNumber);
        if (result.Succeeded)
            _logger.LogInformation("For user {UserName} is set new phone number {phone}.", user.UserName, user.PhoneNumber);
        else
        {
            _logger.LogError("Failed to change phone number ({phone}) for user {UserName}.", user.PhoneNumber, user.UserName);
            foreach (var error in result.Errors)
                _logger.LogError("Detail: {error}", error.Description);
            return result;
        }

        return result;
    }
    public async Task GenerateChangeEmailTokenAsync(ApplicationUser user)
    {
        var code = await _userManager.GenerateChangeEmailTokenAsync(user, user.UserName!);
        code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
        var callbackUrl = _navigationManager.GetUriWithQueryParameters(
        _navigationManager.ToAbsoluteUri("Account/ConfirmEmailChange").AbsoluteUri,
            new Dictionary<string, object?> { ["userId"] = user.Id, ["email"] = user.UserName!, ["code"] = code });

        _logger.LogInformation("A change of e-mail address was requested for user {UserName}.", user.UserName);
        await _emailSender.SendConfirmationLinkAsync(user, user.UserName!, HtmlEncoder.Default.Encode(callbackUrl));
    }
    public async Task GeneratePasswordResetTokenAsync(ApplicationUser user)
    {
        var code = await _userManager.GeneratePasswordResetTokenAsync(user);
        code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
        var callbackUrl = _navigationManager.GetUriWithQueryParameters(
            _navigationManager.ToAbsoluteUri("Account/ResetPassword").AbsoluteUri,
            new Dictionary<string, object?> { ["code"] = code });

        _logger.LogInformation("A password reset was requested for user {UserName}.", user.UserName);
        await _emailSender.SendPasswordResetLinkAsync(user, user.UserName!, HtmlEncoder.Default.Encode(callbackUrl));
    }

    private ApplicationUser CreateUser()
    {
        try
        {
            return Activator.CreateInstance<ApplicationUser>();
        }
        catch
        {
            throw new InvalidOperationException($"Can't create an instance of '{nameof(ApplicationUser)}'. " +
                $"Ensure that '{nameof(ApplicationUser)}' is not an abstract class and has a parameterless constructor.");
        }
    }

    private IUserEmailStore<ApplicationUser> GetEmailStore()
    {
        if (!_userManager.SupportsUserEmail)
        {
            throw new NotSupportedException("The default UI requires a user store with email support.");
        }
        return (IUserEmailStore<ApplicationUser>)_userStore;
    }

}