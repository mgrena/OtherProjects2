using Vetoquinol.API.Contracts.Reporting;

namespace Vetoquinol.API.Contracts;

public interface IAPIClient
{
    int ClientId { get; set; }
    string Account { get; set; }
    string Password { get; set; }

    Task<ResultReport> GetClientsAsync();
    Task<ResultReport> GetProductsAsync();
    Task<ResultReport> GetSalesAsync(DateTime startingDate, DateTime endingDate);
    Task<ResultReport> GetStockAsync();
}