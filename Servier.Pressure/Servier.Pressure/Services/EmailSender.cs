using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Servier.Pressure.Data;
using Servier.Pressure.Helpers;
using System.Net.Mail;
using System.Net;

namespace Servier.Pressure.Services;

public class SmtpOptions
{
    public required string Server { get; set; }
    public required int Port { get; set; }
    public required string Account { get; set; }
    public required string Password { get; set; }
}

public class EmailSender(IOptions<SmtpOptions> optionsAccessor, ILogger<EmailSender> logger) : IEmailSender<ApplicationUser>
{
    private readonly ILogger logger = logger;

    public SmtpOptions Options { get; } = optionsAccessor.Value;

    public Task SendConfirmationLinkAsync(ApplicationUser user, string email,
        string confirmationLink) => SendEmailAsync(email, "ehservices.crmtanzanit.sk overenie e-mail adresy",
        $"<!DOCTYPE html><html><body><p>Dobrý deň,</p>" +
            $"<p>Prijali sme žiadosť o potvrdenie e-mail adresy pre váš účet na stránke <a href='https://ehservices.crmtanzanit.sk/' style='color: blue; text-decoration: underline;'>ehservices.crmtanzanit.sk</a> " +
            $"spoločnosti E&H Services. Tento e-mal Vám prišiel pretože ste boli zaradený/á do projektu MoveOn alebo ste požiadali o znovu odoslanie potvrdenia e-mailom. " +
            $"Ak ste túto požiadavku nevykonali, môžete túto správu ignorovať.</p>" +
            $"<p>E-mail adresu potvrdíte kliknutím na nasledujúci odkaz:</p>" +
            $"<p><a href='{confirmationLink}' style='color: blue; text-decoration: underline;'>Potvrdiť e-mail</a></p>" +
            $"<p>Ak odkaz nefunguje, skopírujte a vložte nasledujúcu adresu do vášho webového prehliadača:</p>" +
            $"<p>{confirmationLink}</p>" +
            $"<p>Odkaz je platný po obmedzený čas.</p><p>S pozdravom,<br>Váš tím podpory</p></body></html>");

    public Task SendPasswordResetLinkAsync(ApplicationUser user, string email,
        string resetLink) => SendEmailAsync(email, "ehservices.crmtanzanit.sk obnovenie hesla",
        $"<!DOCTYPE html><html><body><p>Dobrý deň,</p>" +
            $"<p>Prijali sme vašu žiadosť o zmenu hesla pre váš účet. Ak ste túto požiadavku nevykonali, môžete túto správu ignorovať.</p>" +
            $"<p>Na zmenu vášho hesla kliknite na nasledujúci odkaz:</p><p><a href='{resetLink}' style='color: blue; text-decoration: underline;'>Potvrdiť zmenu hesla</a></p>" +
            $"<p>Ak odkaz nefunguje, skopírujte a vložte nasledujúcu adresu do vášho webového prehliadača:</p>" +
            $"<p>{resetLink}</p>" +
            $"<p>Odkaz je platný po obmedzený čas.</p><p>S pozdravom,<br>Váš tím podpory</p></body></html>");

    public Task SendPasswordResetCodeAsync(ApplicationUser user, string email,
        string resetCode) => SendEmailAsync(email, "ehservices.crmtanzanit.sk obnovenie hesla",
        $"Obnovte svoje heslo pomocou nasledujúceho kódu: {resetCode}");

    public async Task SendEmailAsync(string toEmail, string subject, string message)
    {
        if (string.IsNullOrEmpty(Options.Server))
        {
            throw new Exception("Null SMTP options");
        }

        await Execute(Options, subject, message, toEmail);
    }

    public async Task Execute(SmtpOptions options, string subject, string message, string toEmail)
    {
        await Task.Run(() =>
        {
            try
            {
                MailMessage aMail = new()
                {
                    From = new MailAddress(options.Account),
                    Subject = subject,
                    Body = message,
                    IsBodyHtml = true
                };
                string[] anAddresses = toEmail.Split(";");
                foreach (string address in anAddresses)
                    aMail.To.Add(address);

                // Nastavenie SMTP klienta
                SmtpClient smtpClient = new(options.Server)
                {
                    Port = options.Port,    // Použi 587 pre TLS (alebo 25/465 podľa servera)
                    Credentials = new NetworkCredential(options.Account, CryptFunctions.AESDecryptString(options.Password)),
                    EnableSsl = false       // SSL/TLS zabezpečenie
                };

                // Odoslanie e-mailu
                smtpClient.Send(aMail);

                logger.LogInformation("Email to {EmailAddress} sent!", toEmail);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error sending mail to adress: {EmailAddress}. Error: {Message}", toEmail, ex.Message);
            }
        });
    }
}
