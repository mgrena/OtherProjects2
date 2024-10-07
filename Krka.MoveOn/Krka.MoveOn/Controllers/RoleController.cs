using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Krka.MoveOn.Controllers;

public class RoleController(RoleManager<IdentityRole> roleManager, ILogger<RoleController> logger) : Controller
{
    private readonly RoleManager<IdentityRole> rManager = roleManager;
    private readonly ILogger logger = logger;

    public ViewResult Index() => View(roleManager.Roles);

    private void Errors(IdentityResult result)
    {
        foreach (IdentityError error in result.Errors)
            ModelState.AddModelError("", error.Description);
    }
}
