using Vetoquinol.API.Contracts;
using Vetoquinol.API.Contracts.Data;
using Vetoquinol.API.Contracts.Reporting;
using Medart.SK.Service;
using System.Globalization;

namespace Vetoquinol.Medart.Sk.API;

public class APIClient : IAPIClient
{
    public int ClientId { get; set; } = 0;
    public string Account { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;

    public async Task<ResultReport> GetProductsAsync()
    {
        string aMethodName = "products";
        var aResult = new ResultReport();

        try
        {
            ZTOSServiceClient aClient = new(ZTOSServiceClient.EndpointConfiguration.ZTOSService);
            aClient.ClientCredentials.UserName.UserName = Account;
            aClient.ClientCredentials.UserName.Password = Password;
            ZTOSAuth zTOSAuth = new() { User = Account, Pass = Password };

            var aTask = await aClient.GetProductsAsync(zTOSAuth);
            IList<ProductApi> aList = aTask.GetProductsResult.Products.ToList().Select(i => new ProductApi()
            {
                DistrId = ClientId,
                ProductIdInt = i.ProductID,
                Name = i.Name,
                CatalogPrice = i.CatalogPrice,
                VAT = i.VAT,
                Available = i.Active
            }).ToList();
            aResult.RetunObjects.Add(aMethodName, aList);

            aClient.Close();

            aResult.Statuses.Add(aMethodName, new() { Status = true });
        }
        catch (Exception ex)
        {
            StatusReport aStatus = new() { Status = true };
            processException(ex, ref aStatus);
            aResult.Statuses.Add(aMethodName, aStatus);
        }

        return aResult;
    }
    public async Task<ResultReport> GetClientsAsync()
    {
        string aMethodName = "pharmacies";
        var aResult = new ResultReport();

        try
        {
            ZTOSServiceClient aClient = new(ZTOSServiceClient.EndpointConfiguration.ZTOSService);
            aClient.ClientCredentials.UserName.UserName = Account;
            aClient.ClientCredentials.UserName.Password = Password;
            ZTOSAuth zTOSAuth = new() { User = Account, Pass = Password };

            var aTask = await aClient.GetClientsAsync(zTOSAuth);
            IList<PharmacyApi> aList = aTask.GetClientsResult.Clients.ToList().Select(i => new PharmacyApi()
            {
                DistrId = ClientId,
                ClientIdInt = i.ClientID,
                CenterId = i.BranchCode,
                Ico = i.ICO,
                Name = i.Name,
                Address = i.Street,
                City = i.City,
                ZipCode = i.Zip,
                Canceled = !i.Active
            }).ToList();
            aResult.RetunObjects.Add(aMethodName, aList);

            aClient.Close();

            aResult.Statuses.Add(aMethodName, new() { Status = true });
        }
        catch (Exception ex)
        {
            StatusReport aStatus = new() { Status = true };
            processException(ex, ref aStatus);
            aResult.Statuses.Add(aMethodName, aStatus);
        }

        return aResult;
    }
    public async Task<ResultReport> GetSalesAsync(DateTime startingDate, DateTime endingDate)
    {
        string aMethodName = "sales";
        var aResult = new ResultReport();

        try
        {
            ZTOSServiceClient aClient = new(ZTOSServiceClient.EndpointConfiguration.ZTOSService);
            aClient.ClientCredentials.UserName.UserName = Account;
            aClient.ClientCredentials.UserName.Password = Password;
            ZTOSAuth zTOSAuth = new() { User = Account, Pass = Password };

            DateTime aStartDate = startingDate;
            DateTime anEndDate = (startingDate.AddDays(6) > endingDate) ? endingDate : startingDate.AddDays(6);
            IList<SaleApi> aSalesList = [];
            IList<Task<GetSalesResponse>> aTasks = [aClient.GetSalesAsync(zTOSAuth, aStartDate.ToString("yyyyMMdd"), anEndDate.ToString("yyyyMMdd"))];
            while (anEndDate < endingDate)
            {
                aStartDate = aStartDate.AddDays(7);
                anEndDate = (aStartDate.AddDays(6) > endingDate) ? endingDate : aStartDate.AddDays(6);
                aTasks.Add(aClient.GetSalesAsync(zTOSAuth, aStartDate.ToString("yyyyMMdd"), anEndDate.ToString("yyyyMMdd")));
            }

            while (aTasks.Any())
            {
                Task<GetSalesResponse> aFinishedTask = await Task.WhenAny(aTasks);
                aTasks.Remove(aFinishedTask);
                var aTaskResult = await aFinishedTask;

                IList<SaleApi> aList = aTaskResult.GetSalesResult.Sales.ToList().Select(i => new SaleApi()
                {
                    DistrId = ClientId,
                    ProductId = i.ProductID.ToString(),
                    ClientId = i.ClientID.ToString(),
                    ClientName = i.ClientID.ToString(),
                    Quantity = i.Quantity,
                    BasePrice = i.FinalSalePrice,
                    DeliveryDate = DateTime.TryParseExact(i.DateOfSale, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parseDate) ? parseDate :DateTime.MinValue,
                    Rebate = i.Rabat
                }).ToList();

                aSalesList = [.. aSalesList, .. aList];
            } // while (aTasks.Any())
            aResult.RetunObjects.Add(aMethodName, aSalesList);

            aClient.Close();

            aResult.Statuses.Add(aMethodName, new() { Status = true });
        }
        catch (Exception ex)
        {
            StatusReport aStatus = new() { Status = true };
            processException(ex, ref aStatus);
            aResult.Statuses.Add(aMethodName, aStatus);
        }

        return aResult;
    }
    public async Task<ResultReport> GetStockAsync()
    {
        string aMethodName = "stocks";
        var aResult = new ResultReport();

        try
        {
            ZTOSServiceClient aClient = new(ZTOSServiceClient.EndpointConfiguration.ZTOSService);
            aClient.ClientCredentials.UserName.UserName = Account;
            aClient.ClientCredentials.UserName.Password = Password;
            ZTOSAuth zTOSAuth = new() { User = Account, Pass = Password };

            var aTask = await aClient.GetStocksAsync(zTOSAuth);
            IList<StockApi> aList = aTask.GetStocksResult.BranchStocks.ToList().SelectMany(b => b.ProductStocks.Select(i => new StockApi()
            {
                DistrId = ClientId,
                CenterId = b.BranchCode,
                ProductId = i.ProductID.ToString(),
                Expiration = DateTime.TryParseExact(i.Expiration, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parseDate) ? parseDate : DateTime.MinValue,
                StockLevel = i.Quantity
            })).ToList();
            aResult.RetunObjects.Add(aMethodName, aList);

            aClient.Close();

            aResult.Statuses.Add(aMethodName, new() { Status = true });
        }
        catch (Exception ex)
        {
            StatusReport aStatus = new() { Status = true };
            processException(ex, ref aStatus);
            aResult.Statuses.Add(aMethodName, aStatus);
        }

        return aResult;
    }

    private void processException(Exception ex, ref StatusReport status)
    {
        status.Status = false;
        List<Error> anErrors = [];
        while (true)
        {
            anErrors.Add(new() { Status = 417, Detail = ex.Message, StackTrace = ex.StackTrace });
            if (ex.InnerException == null)
                break;
            ex = ex.InnerException;
        }
        ApiError anError = new() { Errors = [.. anErrors] };
        status.Error = anError;
    }
}
