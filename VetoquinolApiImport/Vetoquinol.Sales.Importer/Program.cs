using DevExpress.Skins;
using DevExpress.UserSkins;
using Vetoquinol.DataAccess;
using Vetoquinol.Sales.Importer.Common.Settings;
using Karatnet.Common;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Vetoquinol.Sales.Importer
{
    internal static class Program
    {
        public static IConfiguration Configuration;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // read app config
            Configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            // read db config
            string aConnString = Configuration.GetSection("DBSettings").GetSection("ConnectionString").Value ?? "";
            string aPassword = CryptFunctions.DecryptString(Configuration.GetSection("DBSettings").GetSection("pwd").Value!);
            if (aConnString.Contains("Password"))
                aConnString = string.Format(aConnString, aPassword);
            DataAccessSettings.DBConnectionString = aConnString;

            // set language
            AppSettings.LanguageCode = Configuration.GetSection("AppSettings").GetSection("LanguageCode").Value ?? "en";
            CultureInfo culture = CultureInfo.CreateSpecificCulture(getCultureName(AppSettings.LanguageCode));
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppForm());
        }

        /// <summary>
        /// From config property LanguageCode generates culture name
        /// </summary>
        private static string getCultureName(string langCode)
        {
            return langCode switch
            {
                "sk" => "sk-SK",
                "cs" => "cs-CZ",
                _ => "en-US",
            };
        }
    }
}