using System.Net;
using System.Net.Http.Headers;
using System.Text;

using Newtonsoft.Json;

using Vetoquinol.API.Contracts;
using Vetoquinol.API.Contracts.Data;
using Vetoquinol.API.Contracts.Reporting;
using Vetoquinol.Topvet.Sk.API.Contracts;

namespace Vetoquinol.Topvet.Sk.API;

public class APIClient : IAPIClient
{
    public string BaseUri { get; set; } = string.Empty;
    public int ClientId { get; set; } = 0;
    public string Account { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;

    public async Task<ResultReport> GetProductsAsync()
    {
        string aMethodName = "products";
        var aResult = new ResultReport();

        try
        {
            using var client = new HttpClient();
            initHttpClient(client);
            var aTaskResult = await getMethodAsync(aMethodName, aMethodName, client);
            aResult.Statuses.Add(aTaskResult.Statuses.First());
            string aContract = (aTaskResult.RetunObjects[aMethodName] == null) ? string.Empty : aTaskResult.RetunObjects[aMethodName]!.ToString()!;
            var aProducts = JsonConvert.DeserializeObject<ProductContract[]>(aContract);
            IList<ProductApi> aList = [.. aProducts!.Select(i => new ProductApi()
            {
                DistrId = ClientId,
                Id = i.id,
                ProductId = i.productId,
                Code = i.code,
                Name = i.name,
                VAT = i.vat,
                CatalogPrice = i.catalogPrice,
                CenterId = i.centerId,
                CenterCode = i.centerCode,
                Ean = i.ean,
                ProducerName = i.producer_name,
                AssortmentName = i.assortment_name,
                RegNumber = i.regNumber,
                PackNumber = i.packNumber,
                Available = i.available
            })];
            aResult.RetunObjects.Add(aMethodName, aList);
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
            using var client = new HttpClient();
            initHttpClient(client);
            string aMethodUri = "clients";
            var aTaskResult = await getMethodAsync(aMethodName, aMethodUri, client);
            aResult.Statuses.Add(aTaskResult.Statuses.First());
            string aContract = aTaskResult.RetunObjects[aMethodName]!.ToString() ?? "";
            var aPharmacies = JsonConvert.DeserializeObject<PharmacyContract[]>(aContract);
            IList<PharmacyApi> aList = aPharmacies!.Select(i => new PharmacyApi()
            {
                DistrId = ClientId,
                ClientApiId = i.clientApiId,
                ClientIdInt = i.clientId,
                Ico = i.ico,
                Name = i.name,
                City = i.city,
                Address = i.street,
                Email = i.email,
                CenterId = i.centerId,
                CenterCode = i.centerCode
            }).ToList();
            aResult.RetunObjects.Add(aMethodName, aList);
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
        var aResult = new ResultReport();

        try
        {
            IList<int> aCenters = [3, 4];

            using var client = new HttpClient();
            initHttpClient(client);

            IList<SaleApi> aSalesList = [];
            IList<Task<ResultReport>> aTasks = [];
            foreach (int center in aCenters)
            {
                for (var day = startingDate.Date; day.Date <= endingDate; day = day.AddDays(1))
                {
                    if (day.DayOfWeek != DayOfWeek.Saturday && day.DayOfWeek != DayOfWeek.Sunday)
                    { 
                        string aMethodName = string.Format("sales_{0}_{1}", center.ToString(), day.ToString("yyyy_MM_dd"));
                        string aMethodUri = string.Format("sales/{0}/{1}", center.ToString(), day.ToString("yyyy-MM-dd"));
                        aTasks.Add(getMethodAsync(aMethodName, aMethodUri, client));
                    }
                }
            }

            while (aTasks.Any())
            {
                Task<ResultReport> aFinishedTask = await Task.WhenAny(aTasks);
                aTasks.Remove(aFinishedTask);
                var aTaskResult = await aFinishedTask;

                if (aTaskResult.RetunObjects.Any() && aTaskResult.RetunObjects.First().Value != null)
                {
                    string aContract = aTaskResult.RetunObjects.First().Value!.ToString() ?? "";
                    var aSalesData = JsonConvert.DeserializeObject<SaleContract[]>(aContract);

                    IList<SaleApi> aList = aSalesData!.Select(i => new SaleApi()
                    {
                        Id = i.id,
                        DistrId = ClientId,
                        CenterId = (i.centerId != null) ? int.Parse(i.centerId) : 0,
                        ProductId = i.productId,
                        ClientId = i.clientId,
                        ClientName = i.name,
                        ClientAddress = i.street,
                        ClientCity = i.city,
                        ClientIco = i.ico,
                        Quantity = (i.quantity != null) ? Utils.StrToDecimalSafety(i.quantity) : 0,
                        BasePrice = (i.priceBase != null) ? Utils.StrToDecimalSafety(i.priceBase) : 0,
                        SetDiscount = (i.setDiscount != null) ? Utils.StrToDecimalSafety(i.setDiscount) : 0,
                        DeliveryDate = (i.dateOfSale != null) ? DateTime.Parse(i.dateOfSale) : null,
                        Rebate = (i.rabat != null && i.rabat == "1")
                    }).ToList();

                    aSalesList = [.. aSalesList, .. aList];
                } // if (aTaskResult.RetunObjects.Any())

                aResult.Statuses.Add(aTaskResult.Statuses.FirstOrDefault());
            } // while (aTasks.Any())

            aResult.RetunObjects.Add("sales", aSalesList);
        }
        catch (Exception ex)
        {
            StatusReport aStatus = new() { Status = true };
            processException(ex, ref aStatus);
            aResult.Statuses.Add("sales", aStatus);
        }

        return aResult;
    }
    public async Task<ResultReport> GetStockAsync()
    {
        var aResult = new ResultReport();

        /*
        try
        {
            IList<int> aCenters = [3, 4];

            using var client = new HttpClient();
            initHttpClient(client);

            IList<StockApi> aStocksList = [];
            IList<Task<ResultReport>> aTasks = [];
            foreach (int center in aCenters)
            {
                string aMethodName = string.Format("stocks_{0}", center.ToString());
                string aMethodUri = string.Format("stock/{0}", center.ToString());
                aTasks.Add(getMethodAsync(aMethodName, aMethodUri, client));
            }

            while (aTasks.Any())
            {
                Task<ResultReport> aFinishedTask = await Task.WhenAny(aTasks);
                aTasks.Remove(aFinishedTask);
                var aTaskResult = await aFinishedTask;

                if (aTaskResult.RetunObjects.Any() && aTaskResult.RetunObjects.First().Value != null)
                {
                    string aContract = aTaskResult.RetunObjects.First().Value!.ToString() ?? "";
                    if (aContract != "{\"message\":\"No stock Found\"}")
                    {
                        var aStockData = JsonConvert.DeserializeObject<StockContract[]>(aContract);
                        IList<StockApi> aList = aStockData!.Select(i => new StockApi()
                        {
                            Id = i.id,
                            DistrId = ClientId,
                            CenterId = i.centerId,
                            ProductId = i.productId,
                            StockLevel = i.stockLevel,
                            BatchNo = i.batch,
                            Expiration = i.expiration
                        }).ToList();

                        aStocksList = aStocksList.Concat(aList).ToList();
                    }
                } // if (aTaskResult.RetunObjects.Any())

                aResult.Statuses.Add(aTaskResult.Statuses.FirstOrDefault());
            } // while (aTasks.Any())

            aResult.RetunObjects.Add("stocks", aStocksList);
        }
        catch (Exception ex)
        {
            StatusReport aStatus = new() { Status = true };
            processException(ex, ref aStatus);
            aResult.Statuses.Add("stocks", aStatus);
        }
        */

        return aResult;
    }

    private async Task<ResultReport> getMethodAsync(string methodName, string methodUri, HttpClient client)
    {
        ResultReport aResult = intMethod(methodName);
        StatusReport aStatus = aResult.Statuses[methodName];

        try
        {
            while (true)
            { 
                HttpResponseMessage response = await client.GetAsync(methodUri);

                // Verification  
                if (response.IsSuccessStatusCode)
                {
                    // Reading Response
                    var content = await response.Content.ReadAsStringAsync();
                    aResult.RetunObjects[methodName] = content;
                    aStatus.Status = true;
                    break;
                }
                else
                {
                    if (response.StatusCode == HttpStatusCode.TooManyRequests)
                    {
                        TimeSpan? aDelta = response.Headers.RetryAfter!.Delta;
                        Thread.Sleep(aDelta!.Value.Seconds * 1000);
                    }
                    else
                    {
                        processBadRequest(response, ref aStatus);
                        break;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            processException(ex, ref aStatus);
        }

        return aResult;
    }
    private void initHttpClient(HttpClient client)
    {
        var anAuthString = $"{Account}:{Password}";
        var aBase64EncodedAuthString = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(anAuthString));

        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", aBase64EncodedAuthString);
        client.BaseAddress = new Uri(BaseUri);
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }
    private static ResultReport intMethod(string methodName)
    {
        ResultReport aResult = new();
        aResult.Statuses.Add(methodName, new() { Status = true });
        aResult.RetunObjects.Add(methodName, null);

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
    private void processBadRequest(HttpResponseMessage response, ref StatusReport status)
    {
        var errorData = response.Content.ReadAsStringAsync().Result;
        dynamic me = JsonConvert.DeserializeObject(errorData)!;

        status.Status = false;
        status.Error = new()
        {
            Errors = new Error[] { new() {
                                Status = (int)response.StatusCode,
                                Phrase = String.Format("{0}: {1}", (int)response.StatusCode, response.ReasonPhrase),
                                Detail = me.message
                            } }
        };
    }
}