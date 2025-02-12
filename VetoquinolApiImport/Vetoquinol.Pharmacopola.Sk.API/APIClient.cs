using Vetoquinol.API.Contracts;
using Vetoquinol.API.Contracts.Data;
using Vetoquinol.API.Contracts.Reporting;
using Pharmacopola.SK.Service;

namespace Vetoquinol.Pharmacopola.Sk.API
{
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
                Vendor_PortClient aClient = new();
                aClient.ClientCredentials.UserName.UserName = Account;
                aClient.ClientCredentials.UserName.Password = Password;

                var aTask = await aClient.GetProductsAsync();
                IList<ProductApi> aList = [];
                if (aTask.returnProductList != null)
                { 
                    aList = aTask.returnProductList.ToList().Select(i => new ProductApi()
                    {
                        DistrId = ClientId,
                        ProductId = i.ProductID,
                        VendorProductId = i.VendorProductID,
                        Name = i.Name,
                        CatalogPrice = i.CatalogPrice,
                        VAT = i.VAT,
                        Finished = i.Finished
                    }).ToList();
                }
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
                Vendor_PortClient aClient = new();
                aClient.ClientCredentials.UserName.UserName = Account;
                aClient.ClientCredentials.UserName.Password = Password;

                var aTask = await aClient.GetClientsAsync(new GetClients());
                IList<PharmacyApi> aList = aTask.returnClients.ClientLine.Select(i => new PharmacyApi()
                {
                    DistrId = ClientId,
                    ClientId = i.ClientId,
                    ClientMasterId = i.ClientMasterId,
                    PreviousMasterId = i.PreviousMasterId,
                    Name = i.Name,
                    Name2 = i.Name2,
                    Address = i.Address,
                    Address2 = i.Address2,
                    City = i.City,
                    ZipCode = i.ZipCode,
                    RegNo = i.RegNo,
                    RegName = i.RegName,
                    Canceled = i.Canceled
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
                Vendor_PortClient aClient = new();
                aClient.ClientCredentials.UserName.UserName = Account;
                aClient.ClientCredentials.UserName.Password = Password;

                int anErrorCode = 999;
                string anErrorText = "test";
                var aTask = await aClient.GetSalesAsync(new GetSales(startingDate, endingDate, new SalesList(), anErrorCode, anErrorText));
                anErrorCode = aTask.returnErrorCode;
                anErrorText = aTask.returnErrorText;
                IList<SaleApi> aList = [];
                if (aTask.returnSalesList != null && aTask.returnSalesList.SalesEntry != null)
                { 
                    aList = aTask.returnSalesList.SalesEntry.Select(i => new SaleApi()
                    {
                        DistrId = ClientId,
                        ProductId = i.ProductID, 
                        ProductName = i.ProductName,
                        ClientMasterId = i.ClientMasterID,
                        ClientId = i.ClientID,
                        ClientName = i.ClientName,
                        ClientName2 = i.ClientName2,
                        ClientAddress = i.ClientAddress,
                        ClientAddress2 = i.ClientAddress2,
                        ClientCity = i.ClientCity,
                        ClientZIP = i.ClientZIP,
                        ClientRegNo = i.ClientRegNo,
                        Quantity = i.Quantity,
                        BasePrice = i.BasePrice,
                        DeliveryDate = i.DeliveryDate,
                        Rebate = i.Rebate
                    }).ToList();
                }
                aResult.RetunObjects.Add(aMethodName, aList);
                if (anErrorCode != 999 && anErrorCode != 0)
                    aResult.Statuses.Add(aMethodName, new() { Status = false, Error = new() { Errors = [new() { Status = anErrorCode, Detail = anErrorText }] } });
                else
                    aResult.Statuses.Add(aMethodName, new() { Status = true });

                aClient.Close();
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
                Vendor_PortClient aClient = new();
                aClient.ClientCredentials.UserName.UserName = Account;
                aClient.ClientCredentials.UserName.Password = Password;

                var aTask = await aClient.GetStockAsync();
                IList<StockApi> aList = new List<StockApi>();
                if (aTask.returnStockList != null)
                { 
                    aList = aTask.returnStockList.ToList().Select(i => new StockApi()
                    {
                        DistrId = ClientId,
                        ProductId = i.ProductID,
                        BatchNo = i.BatchNo,
                        Expiration = i.Expiration,
                        StockLevel = i.StockLevel,
                        ReservedQtyOnStockLevel = i.ReservedQtyOnStockLevel
                    }).ToList();
                }
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
}