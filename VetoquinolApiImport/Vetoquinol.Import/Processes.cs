using System.Net.Mail;
using System.Net;

using Vetoquinol.API.Contracts;
using Vetoquinol.API.Contracts.Reporting;
using Vetoquinol.DataAccess;
using Vetoquinol.DataAccess.Contracts;
using Vetoquinol.Import.Contracts;
using Microsoft.EntityFrameworkCore;
using Vetoquinol.API.Contracts.Data;
using System.Data;
using System.Text;
using System.ServiceModel.Channels;

namespace Vetoquinol.Import;

public class Processes
{
    private static object myLock = new();

    public static string CryptPwd(string origPwd)
    {
        string result = CryptFunctions.AESEncryptString(origPwd);
        //string test = CryptFunctions.AESDecryptString(result);
        return result;
    }
    public static async Task<StatusReport> ProcessBatchAsync(AppSettings appSettings, DateTime? startingDate, DateTime? endingDate)
    {
        StatusReport aResult = new() { Status = true };

        try
        {
            Dictionary<string, object?> aData = [];
            Dictionary<string, List<string>> aMissData = [];

            if (!startingDate.HasValue)
                startingDate = DateTime.Now.AddDays(7 - (int)DateTime.Now.DayOfWeek - 7).Date;
            if (!endingDate.HasValue)
                endingDate = DateTime.Now.AddDays(((int)DayOfWeek.Saturday - (int)DateTime.Now.DayOfWeek + 7) % 7).Date.AddDays(1).AddSeconds(-1);

            using (var context = new VetoquinolSourceDataContext())
            {
                //context.Pharmacies.ExecuteDelete();
                //context.Products.ExecuteDelete();
                //context.SaleData.ExecuteDelete();

                bool isError = false;
                foreach (var client in ApiSettings.Clients)
                {
                    IAPIClient? anApiClient = null;
                    switch (client.Value.Id)
                    {
                        case 1:
                            anApiClient = new Vetoquinol.Pharmacopola.Sk.API.APIClient();
                            break;
                        case 2:
                            anApiClient = new Vetoquinol.Topvet.Sk.API.APIClient() { BaseUri = client.Value.BaseUri! };
                            break;
                        case 3:
                            anApiClient = new Vetoquinol.Samohyl.Cz.API.APIClient();
                            break;
                        case 4:
                            anApiClient = new Vetoquinol.Noviko.Cz.API.APIClient();
                            break;
                        case 5:
                            anApiClient = new Vetoquinol.SGVet.Cz.API.APIClient();
                            break;
                        case 6:
                            anApiClient = new Vetoquinol.Medart.Sk.API.APIClient();
                            break;
                    }
                    anApiClient!.ClientId = client.Value.Id;
                    anApiClient!.Account = client.Value.Account!;
                    //string a = CryptPwd(client.Value.Password);
                    anApiClient!.Password = CryptFunctions.AESDecryptString(client.Value.Password);

                    IList<Task<ResultReport>> aTasks =
                    [
                        anApiClient.GetProductsAsync(),
                        anApiClient.GetClientsAsync(),
                        anApiClient.GetSalesAsync(startingDate!.Value, endingDate!.Value),
                        anApiClient.GetStockAsync()
                    ];
                    await Task.WhenAll(aTasks);

                    // process task results
                    aData.Clear();
                    foreach (Task<ResultReport> task in aTasks)
                    {
                        var aTaskResult = await task;
                        foreach (KeyValuePair<string, StatusReport> status in aTaskResult.Statuses)
                        {
                            if (!status.Value.Status)
                            {
                                isError = true;
                                if (aResult.Status)
                                {
                                    aResult.Status = false;
                                    aResult.Error = status.Value.Error;
                                }
                                WriteMessage(string.Format(": {0} - {1}", client.Value.Client, status.Key));
                                if (status.Value.Error != null && status.Value.Error.Errors!.Length > 0)
                                    foreach (var err in status.Value.Error.Errors!)
                                    { 
                                        WriteMessage(string.Format(" - {0} - {1}", err.Status, err.Detail));
                                        if (err.StackTrace != null)
                                            WriteMessage(err.StackTrace);
                                    }
                            }
                        }
                        foreach (KeyValuePair<string, object?> result in aTaskResult.RetunObjects)
                            aData.Add(result.Key, result.Value);
                    } // foreach (Task<ResultReport> task in aTasks)

                    // process data
                    if (!aData.TryGetValue("products", out object? value) || value == null || !((IList<ProductApi>)value!).Any())
                    {
                        // Samohyl (id = 3) nemá produkty
                        if (client.Value.Id != 3)
                        { 
                            aMissData.Add(client.Value.Client!, []);
                            aMissData[client.Value.Client!].Add("products");
                        }
                    }
                    else
                    {
                        context.Products.AddRange(((IList<ProductApi>)value!).Select(i => new Product() {
                            DistrId = i.DistrId,
                            IdDef = i.Id,
                            ProductIdInt = i.ProductIdInt,
                            CenterId = i.CenterId,
                            Available = i.Available,
                            ProductId = i.ProductId,
                            VendorProductId = i.VendorProductId,
                            Code = i.Code,
                            Name = i.Name!,
                            Vat = i.VAT,
                            CatalogPrice = i.CatalogPrice,
                            CenterCode = i.CenterCode,
                            Ean = i.Ean,
                            ProducerName = i.ProducerName,
                            AssortmentName = i.AssortmentName,
                            RegNumber = i.RegNumber,
                            PackNumber = i.PackNumber,
                            Finished = i.Finished
                        }));
                    }
                    if (!aData.TryGetValue("pharmacies", out object? phValue) || phValue == null || !((IList<PharmacyApi>)phValue!).Any())
                    {
                        // Noviko (id = 4) a SGVet (id = 5) nemá lekarne
                        if (client.Value.Id != 4 && client.Value.Id != 5)
                        { 
                            if (!aMissData.ContainsKey(client.Value.Client!))
                                aMissData.Add(client.Value.Client!, []);
                            aMissData[client.Value.Client!].Add("pharmacies");
                        }
                    }
                    else
                    {
                        context.Pharmacies.AddRange(((IList<PharmacyApi>)phValue!).Select(i => new Pharmacy() {
                            DistrId = i.DistrId,
                            ClientIdInt = i.ClientIdInt,
                            ClientApiId = i.ClientApiId,
                            CenterId = i.CenterId,
                            Canceled = i.Canceled,
                            Priceless = i.Priceless,
                            ClientId = i.ClientId!,
                            ClientMasterId = i.ClientMasterId,
                            PreviousMasterId = i.PreviousMasterId,
                            Name = i.Name!,
                            Name2 = i.Name2,
                            Address = i.Address,
                            Address2 = i.Address2,
                            City = i.City!,
                            ZipCode = i.ZipCode!,
                            Ico = i.Ico,
                            Email = i.Email,
                            Phone = i.Phone,
                            RegNo = i.RegNo,
                            RegName = i.RegName,
                            CenterCode = i.CenterCode
                        }));
                    }
                    if (!aData.TryGetValue("sales", out object? sValue) || sValue == null || !((IList<SaleApi>)sValue!).Any())    
                    {
                        if (!aMissData.ContainsKey(client.Value.Client!))
                            aMissData.Add(client.Value.Client!, []);
                        aMissData[client.Value.Client!].Add("sales");
                    }
                    else
                    {
                        context.SaleData.AddRange(((IList<SaleApi>)sValue!).Select(i => new SaleDatum() {
                            DistrId = i.DistrId,
                            CenterId = i.CenterId,
                            Rebate = i.Rebate,
                            Quantity = i.Quantity,
                            BasePrice = i.BasePrice,
                            SetDiscount = i.SetDiscount,
                            IdDef = i.Id,
                            ProductId = i.ProductId,
                            ProductName = (i.Rebate) ? string.Format("{0} RABAT", i.ProductName) : i.ProductName,
                            ClientMasterId = i.ClientMasterId,
                            ClientId = i.ClientId,
                            ClientName = i.ClientName!,
                            ClientName2 = i.ClientName2,
                            ClientAddress = i.ClientAddress,
                            ClientAddress2 = i.ClientAddress2,
                            ClientCity = i.ClientCity,
                            ClientZip = i.ClientZIP,
                            ClientRegNo = i.ClientRegNo,
                            ClientIco = i.ClientIco,
                            DeliveryDate = i.DeliveryDate,
                            OrderNo = i.OrderNo,
                            BatchNo = i.BatchNo
                        }));
                    }
                    if (!aData.TryGetValue("stocks", out object? tValue) || tValue == null || !((IList<StockApi>)tValue!).Any())    
                    {
                        if (!aMissData.ContainsKey(client.Value.Client!))
                            aMissData.Add(client.Value.Client!, []);
                        aMissData[client.Value.Client!].Add("stocks");
                    }
                    else
                    {
                        context.Stocks.AddRange(((IList<StockApi>)tValue!).Select(i => new Stock() {
                            DistrId = i.DistrId,
                            IdDef = i.Id,
                            CenterId = i.CenterId,
                            StockLevel = i.StockLevel,
                            ReservedQtyOnStockLevel = i.ReservedQtyOnStockLevel,
                            Expiration = processDate(i.Expiration),
                            ProductId = i.ProductId,
                            BatchNo = i.BatchNo
                        }));
                    }
                } // foreach (var client in ApiSettings.Clients)
                if (isError)
                    sendMail("Pri generovaní dát pre Vetoquinol došlo k chybe! Skontroluj logy.", appSettings.ErrorEmail!);

                // copy data to full tables
                context.SaveChanges();
                context.Database.ExecuteSql($"exec process_import_data");

                // generate sales csv files
                foreach (var client in ApiSettings.Clients)
                {
                    DataTable aTable = new();
                    string aFileName = string.Empty;
                    switch (client.Value.Id)
                    {
                        case 1:
                            aTable = context.VPharmacopolaSks.Where(i => i.DeliveryDate >= startingDate && i.DeliveryDate <= endingDate).ToList().ToDataTable();
                            aFileName = string.Format("Vetoquinol_Pharmacopola_SK_{0}.csv", DateTime.Now.ToString("yyyyMMdd"));
                            break;
                        case 2:
                            aTable = context.VTopvetSks.Where(i => i.DeliveryDate >= startingDate && i.DeliveryDate <= endingDate).ToList().ToDataTable();
                            aFileName = string.Format("Vetoquinol_Topvet_SK_{0}.csv", DateTime.Now.ToString("yyyyMMdd"));
                            break;
                        case 3:
                            aTable = context.VSamohylCzs.Where(i => i.DeliveryDate >= startingDate && i.DeliveryDate <= endingDate).ToList().ToDataTable();
                            aFileName = string.Format("Vetoquinol_Samohyl_CZ_{0}.csv", DateTime.Now.ToString("yyyyMMdd"));
                            break;
                        case 4:
                            aTable = context.VNovikoCzs.Where(i => i.DeliveryDate >= startingDate && i.DeliveryDate <= endingDate).ToList().ToDataTable();
                            aFileName = string.Format("Vetoquinol_Noviko_CZ_{0}.csv", DateTime.Now.ToString("yyyyMMdd"));
                            break;
                        case 5:
                            aTable = context.VSgvetCzs.Where(i => i.DeliveryDate >= startingDate && i.DeliveryDate <= endingDate).ToList().ToDataTable();
                            aFileName = string.Format("Vetoquinol_SGVet_CZ_{0}.csv", DateTime.Now.ToString("yyyyMMdd"));
                            break;
                        case 6:
                            aTable = context.VMedArtSks.Where(i => i.DeliveryDate >= startingDate && i.DeliveryDate <= endingDate).ToList().ToDataTable();
                            aFileName = string.Format("Vetoquinol_MedArt_SK_{0}.csv", DateTime.Now.ToString("yyyyMMdd"));
                            break;
                    }
                    aFileName = Path.Combine(appSettings.ExportSalesPath!, aFileName);
                    toCSV(aTable, aFileName);
                }
            } // using (var context = new VetoquinolSourceDataContext())

            if (aMissData.Count != 0)
            {
                string aMessage = "Nasledujúce dátové balíky sa nepodarilo stiahnúť:" + Environment.NewLine;
                foreach(KeyValuePair<string, List<string>> entry in aMissData) 
                    foreach (string item in entry.Value)
                        aMessage += " - " + entry.Key + ": " + item + Environment.NewLine;
                sendMail(aMessage, appSettings.ErrorEmail!);
            }
        }
        catch (Exception ex)
        {
            processException(ex);
            aResult.Status = false;
        }

        return aResult;
    }

    public static void WriteMessage(string message)
    {
        lock (myLock)
        {
            string aLogFile = getLogFile();
            using StreamWriter sw = new(File.Open(aLogFile, FileMode.Append));
            sw.WriteLine(string.Format("{0} {1}", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"), message));
        }
    }
    private static string getLogFile()
    {
        string aLogFileDefaultName = "syncData.log";
        string aLogDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log");
        if (!Directory.Exists(aLogDirectory))
            Directory.CreateDirectory(aLogDirectory);

        if (File.Exists(Path.Combine(aLogDirectory, aLogFileDefaultName)))
        {
            long aLogFileSize = new FileInfo(Path.Combine(aLogDirectory, aLogFileDefaultName)).Length;
            if (aLogFileSize > 1024 * 1024 * 10)
            {
                int aFileCount = Directory.GetFiles(aLogDirectory, "*.log").Length;
                string aNewFileName = aLogFileDefaultName.Replace(".", string.Format("_{0}.", aFileCount));
                File.Move(Path.Combine(aLogDirectory, aLogFileDefaultName), Path.Combine(aLogDirectory, aNewFileName));
                File.Create(Path.Combine(aLogDirectory, aLogFileDefaultName)).Close();
            }
        }
        else
        {
            File.Create(Path.Combine(aLogDirectory, aLogFileDefaultName)).Close();
        }

        return Path.Combine(aLogDirectory, aLogFileDefaultName);
    }
    private static void processException(Exception? ex)
    {
        while (ex != null)
        {
            WriteMessage(ex.Message);
            if (ex.StackTrace != null) WriteMessage(ex.StackTrace);
            ex = ex.InnerException;
        }
    }
    private static void sendMail(string message, string addresses)
    {
        try
        {
            string aSMTPserver = "smtp.websupport.sk";
            int aSMTPport = 25;
            string aSMTPaccount = "morfo@allio.sk";
            string aSMTPpwd = @"Pk5/j5uP\W";
            string aMailForm = "morfo@allio.sk";

            MailMessage aMail = new();
            SmtpClient aSmtpServer = new(aSMTPserver);

            aMail.From = new(aMailForm);
            string[] anAddresses = addresses.Split(";");
            foreach (string address in anAddresses)
                aMail.To.Add(address);
            aMail.Subject = "Vetoquinol.Import error";
            aMail.Body = message;

            aSmtpServer.Port = aSMTPport;
            aSmtpServer.Credentials = new NetworkCredential(aSMTPaccount, aSMTPpwd);
            aSmtpServer.EnableSsl = false;

            aSmtpServer.Send(aMail);
        }
        catch (Exception ex)
        {
            processException(ex);
        }
    }
    /// <summary>
    /// Converts the DataTable to CSV
    /// </summary>
    /// <param name="table">source data</param>
    /// <param name="strFilePath">path to stored csv file</param>
    private static void toCSV(DataTable table, string strFilePath)
    {
        StreamWriter sw = new(strFilePath, false, Encoding.UTF8);
        //headers    
        for (int i = 0; i < table.Columns.Count; i++)
        {
            sw.Write(table.Columns[i]);
            if (i < table.Columns.Count - 1)
            {
                sw.Write(";");
            }
        }
        sw.Write(sw.NewLine);
        foreach (DataRow dr in table.Rows)
        {
            for (int i = 0; i < table.Columns.Count; i++)
            {
                if (!Convert.IsDBNull(dr[i]))
                {
                    sw.Write(dr[i].ToString());
                }
                if (i < table.Columns.Count - 1)
                {
                    sw.Write(";");
                }
            }
            sw.Write(sw.NewLine);
        }
        sw.Close();
    }
    private static DateTime? processDate(DateTime? date)
    {
        if (date.HasValue)
            //return new DateTime[] { date.Value, new(2020, 1, 1) }.Max();
            if (date.Value < new DateTime(2020, 1, 1))
                return new(2020, 1, 1);
            else
                return date;
        else
            return date;
    }

}
