using System.Globalization;

namespace Vetoquinol.Topvet.Sk.API;

internal class Utils
{
    /// <summary>
    /// Converts string value to readable decimal format
    /// </summary>
    public static decimal StrToDecimalSafety(string value)
    {
        decimal aResult;
        value = value.Replace(" ", "").Trim();
        // Number format: 1,000.00
        if (decimal.TryParse(value, NumberStyles.Float, CultureInfo.GetCultureInfo("en-US"), out aResult))
        {
            return aResult;
        }
        // Number format: 1.000,00
        else if (decimal.TryParse(value, NumberStyles.Float, CultureInfo.GetCultureInfo("de-DE"), out aResult))
        {
            return aResult;
        }
        // Number format: 1 000,00
        else if (decimal.TryParse(value, NumberStyles.Float, CultureInfo.GetCultureInfo("cs-CZ"), out aResult))
        {
            return aResult;
        }
        // Number format: 1 000,00
        else if (decimal.TryParse(value, NumberStyles.Float, CultureInfo.GetCultureInfo("sk-SK"), out aResult))
        {
            return aResult;
        }

        return 0;
    }
}
