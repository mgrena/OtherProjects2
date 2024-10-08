using Krka.MoveOn.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace Krka.MoveOn.Components.Account {
    // Remove the "else if (EmailSender is IdentityNoOpEmailSender)" block from RegisterConfirmation.razor after updating with a real implementation.
    internal sealed class IdentityNoOpEmailSender : IEmailSender<ApplicationUser> {
        private readonly IEmailSender emailSender = new NoOpEmailSender();

        public Task SendConfirmationLinkAsync(ApplicationUser user, string email, string confirmationLink) =>
            emailSender.SendEmailAsync(email, "Potvrďte svoj e-mail", $"Potvrďte svoj účet <a href='{confirmationLink}'>kliknutím sem</a>.");

        public Task SendPasswordResetLinkAsync(ApplicationUser user, string email, string resetLink) =>
            emailSender.SendEmailAsync(email, "Obnovte svoje heslo", $"Obnovte si heslo <a href='{resetLink}'>kliknutím sem</a>.");

        public Task SendPasswordResetCodeAsync(ApplicationUser user, string email, string resetCode) =>
            emailSender.SendEmailAsync(email, "Obnovte svoje heslo", $"Obnovte svoje heslo pomocou nasledujúceho kódu: {resetCode}");
    }
}