using Krka.MoveOn.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Krka.MoveOn.Services.Pages;

public class UserService(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
{
    private readonly UserManager<ApplicationUser> _userManager = userManager;
    private readonly RoleManager<IdentityRole> _roleManager = roleManager;

    public async Task<List<ApplicationUser>> GetUsersAsync()
    {
        var users = await _userManager.Users.ToListAsync();
        var roles = await _roleManager.Roles.ToListAsync();
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

    public async Task<IdentityResult> CreateUserAsync(ApplicationUser user, string password)
    {
        var result = await _userManager.CreateAsync(user, password);
        return result;
    }

    public async Task<IdentityResult> AddUserToRoleAsync(ApplicationUser user, string role)
    {
        var result = await _userManager.AddToRoleAsync(user, role);
        return result;
    }
}