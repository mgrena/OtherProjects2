using Vetoquinol.API.Contracts;
using Vetoquinol.API.Contracts.Data;
using Vetoquinol.API.Contracts.Reporting;
using Noviko.CZ.Service;

namespace Vetoquinol.Noviko.Cz.API;

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
            HSB2BwsClient aClient = new();
            aClient.ClientCredentials.UserName.UserName = Account;
            aClient.ClientCredentials.UserName.Password = Password;

            var aTask = await aClient.getProductsAsync();
            IList<ProductApi> aList = aTask.@return.ToList().Select(i => new ProductApi()
            {
                DistrId = ClientId,
                ProductIdInt = i.productId,
                ProductId = i.productIdKey,
                Name = i.name,
                Code = i.pdkId,
                CatalogPrice = (decimal)i.catalogPrice,
                VAT = (decimal)i.VAT,
                ProducerName = i.supplierId,
                Available = !i.finished
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

        /*
        HSB2BwsClient aClient = new();
        aClient.ClientCredentials.UserName.UserName = Account;
        aClient.ClientCredentials.UserName.Password = Password;

        var aTask = await aClient.getClientsAsync();
        IList<PharmacyApi> aList = aTask.@return.Select(i => new PharmacyApi()
        {
            DistrId = ClientId,
            ClientId = i.clientIdKey,
            ClientIdInt = i.clientId,
            ClientMasterId = i.clientMasterIdKey,
            PreviousMasterId = i.clientMasterId.ToString(),
            Email = i.email,
            Phone = i.phoneNumber,
            Ico = i.IC,
            Name = i.name,
            Address = i.street,
            City = i.city,
            ZipCode = i.zip,
            Canceled = i.finished,
            Priceless = i.priceless
        }).ToList();
        aResult.RetunObjects.Add("pharmacies", aList);

        aClient.Close();
        */

        aResult.Statuses.Add("pharmacies", new() { Status = true });
        return aResult;
    }
    public async Task<ResultReport> GetSalesAsync(DateTime startingDate, DateTime endingDate)
    {
        string aMethodName = "sales";
        var aResult = new ResultReport();

        try
        {
            HSB2BwsClient aClient = new();
            aClient.ClientCredentials.UserName.UserName = Account;
            aClient.ClientCredentials.UserName.Password = Password;

            DateTime aStartDate = startingDate;
            DateTime anEndDate = (startingDate.AddDays(6) > endingDate) ? endingDate : startingDate.AddDays(6);
            IList<SaleApi> aSalesList = [];
            IList<Task<getSalesResponse>> aTasks = [aClient.getSalesAsync(aStartDate, anEndDate)];
            while (anEndDate < endingDate)
            {
                aStartDate = aStartDate.AddDays(7);
                anEndDate = (aStartDate.AddDays(6) > endingDate) ? endingDate : aStartDate.AddDays(6);
                aTasks.Add(aClient.getSalesAsync(aStartDate, anEndDate));
            }

            while (aTasks.Any())
            {
                Task<getSalesResponse> aFinishedTask = await Task.WhenAny(aTasks);
                aTasks.Remove(aFinishedTask);
                var aTaskResult = await aFinishedTask;

                IList<SaleApi> aList = aTaskResult.@return.Select(i => new SaleApi()
                {
                    DistrId = ClientId,
                    BatchNo = i.batchNo,
                    ProductId = i.productId.ToString(),
                    ClientMasterId = i.clientId.ToString(),
                    ClientId = i.clientKey,
                    ClientName = i.clientName,
                    ClientAddress = i.clientStreet,
                    ClientCity = i.clientCity,
                    ClientZIP = i.clientZip,
                    ClientIco = i.clientIC,
                    Quantity = (decimal)i.quantity,
                    BasePrice = (decimal)i.priceBase,
                    DeliveryDate = i.dateOfSale,
                    OrderNo = i.orderId.ToString(),
                    Rebate = i.rabat
                }).ToList();

                aSalesList = aSalesList.Concat(aList).ToList();
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
            HSB2BwsClient aClient = new();
            aClient.ClientCredentials.UserName.UserName = Account;
            aClient.ClientCredentials.UserName.Password = Password;

            var aTask = await aClient.getStocksAsync();
            IList<StockApi> aList = aTask.@return.ToList().Select(i => new StockApi()
            {
                DistrId = ClientId,
                ReservedQtyOnStockLevel = (decimal)i.batchId,
                ProductId = i.productId.ToString(),
                BatchNo = i.batchNo,
                Expiration = (i.expiration < new DateTime(2000, 1, 1)) ? null : i.expiration,
                StockLevel = (decimal)i.stockLevel
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