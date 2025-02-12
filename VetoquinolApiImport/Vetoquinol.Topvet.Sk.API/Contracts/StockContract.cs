namespace Vetoquinol.Topvet.Sk.API.Contracts;

internal class StockContract
{
    public int id { get; set; }
    public string? productId { get; set; }
    public int stockLevel { get; set; }
    public string? batch { get; set; }
    public DateTime? expiration { get; set; }
    public DateTime day { get; set; }
    public int centerId { get; set; }
}
