using Krka.MoveOn.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Net.Mail;
using System.Net;

namespace Krka.MoveOn.Services;

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
        string confirmationLink) => SendEmailAsync(email, "Potvrďte svoj e-mail",
        "Potvrďte svoj účet " +
        $"<a href='{confirmationLink}'>kliknutím sem</a>.");

    public Task SendPasswordResetLinkAsync(ApplicationUser user, string email,
        string resetLink) => SendEmailAsync(email, "Obnovte svoje heslo",
        $"Obnovte si heslo <a href='{resetLink}'>kliknutím sem</a>.");

    public Task SendPasswordResetCodeAsync(ApplicationUser user, string email,
        string resetCode) => SendEmailAsync(email, "Obnovte svoje heslo",
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
                logger.LogError("Error sending mail to adress: {EmailAddress}. Error: {Message}", toEmail, ex.Message);
                logger.LogError(ex.StackTrace);
            }
        });
    }
}
