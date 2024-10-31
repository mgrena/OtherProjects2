using System.Text.RegularExpressions;

namespace Krka.MoveOn.Services;

public class EmailValidator
{
    private static readonly Regex EmailRegex = new(
        @"^[^@\s]+@[^@\s]+\.[^@\s]+$", 
        RegexOptions.Compiled | RegexOptions.IgnoreCase);

    public static bool IsValidEmail(string email)
    {
        return EmailRegex.IsMatch(email);
    }
}
