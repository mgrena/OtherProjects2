using Krka.MoveOn.Data;
using Microsoft.AspNetCore.Identity;

namespace Krka.MoveOn.Components.Account {
    internal sealed class IdentityUserAccessor(UserManager<ApplicationUser> userManager, IdentityRedirectManager redirectManager) {
        public async Task<ApplicationUser> GetRequiredUserAsync(HttpContext context) {
            var user = await userManager.GetUserAsync(context.User);

            if(user is null) {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Chyba: Používateľa s ID '{userManager.GetUserId(context.User)}' sa nepodarilo načítať.", context);
            }

            return user;
        }
    }
}