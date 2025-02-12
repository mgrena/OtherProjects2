namespace Vetoquinol.API.Contracts.Data;

public class StockApi
{
    public int Id { get; set; }
    public int DistrId { get; set; }
    public int? CenterId { get; set; }
    public string? ProductId { get; set; }
    public string? BatchNo { get; set; }
    public DateTime? Expiration { get; set; }
    public decimal StockLevel { get; set; }
    public decimal ReservedQtyOnStockLevel { get; set; }

}
