using Krka.MoveOn.Components.Pages;
using Krka.MoveOn.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Text.Encodings.Web;

namespace Krka.MoveOn.Services.Pages;

public class UserService(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, NavigationManager navigationManager, IUserStore<ApplicationUser> userStore,
    IEmailSender<ApplicationUser> emailSender, ILogger<UserService> logger)
{
    private readonly UserManager<ApplicationUser> _userManager = userManager;
    private readonly RoleManager<IdentityRole> _roleManager = roleManager;
    private readonly NavigationManager _navigationManager = navigationManager;
    private readonly IUserStore<ApplicationUser> _userStore = userStore;
    private readonly IEmailSender<ApplicationUser> _emailSender = emailSender;
    private readonly ILogger _logger = logger;

    public async Task<List<ApplicationUser>> GetUsersAsync()
    {
        // read all users
        var users = await _userManager.Users.ToListAsync();
        // read all roles
        var roles = await _roleManager.Roles.ToListAsync();
        // for each user read and assign role
        foreach (var user in users)
        {
            var userRoles = await _userManager.GetRolesAsync(user);
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
            _navigationManager.ToAbsoluteUri("Account/ConfirmEmail").AbsoluteUri,
            new Dictionary<string, object?> { ["userId"] = userId, ["code"] = code, ["returnUrl"] = @"/" });

        await _emailSender.SendConfirmationLinkAsync(dummyUser, user.UserName!, HtmlEncoder.Default.Encode(callbackUrl));

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
            if (userRole != null && userRole.Count > 0) { 
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
            userOrig.LockoutEnabled = user.LockoutEnabled;
            userOrig.LockoutEnd = user.LockoutEnd;

            // update user in database
            result = await _userManager.UpdateAsync(userOrig);
            if (result.Succeeded)
                _logger.LogInformation("The user {UserName} has been successfully changed.", user.UserName);
            else
            {
                _logger.LogError("Could not change user {UserName}.",  user.UserName);
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

        await _emailSender.SendConfirmationLinkAsync(user, user.UserName!, HtmlEncoder.Default.Encode(callbackUrl));
    }

    private ApplicationUser CreateUser()
    {
        try {
            return Activator.CreateInstance<ApplicationUser>();
        }
        catch {
            throw new InvalidOperationException($"Can't create an instance of '{nameof(ApplicationUser)}'. " +
                $"Ensure that '{nameof(ApplicationUser)}' is not an abstract class and has a parameterless constructor.");
        }
    }

    private IUserEmailStore<ApplicationUser> GetEmailStore()
    {
        if (!_userManager.SupportsUserEmail) {
            throw new NotSupportedException("The default UI requires a user store with email support.");
        }
        return (IUserEmailStore<ApplicationUser>)_userStore;
    }

}