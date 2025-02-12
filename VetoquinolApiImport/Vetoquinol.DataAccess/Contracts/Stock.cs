namespace Vetoquinol.DataAccess.Contracts;

public partial class Stock
{
    public int Id { get; set; }

    public int DistrId { get; set; }

    public int IdDef { get; set; }

    public int? CenterId { get; set; }

    public decimal StockLevel { get; set; }

    public decimal ReservedQtyOnStockLevel { get; set; }

    public DateTime? Expiration { get; set; }

    public string? ProductId { get; set; } = null!;

    public string? BatchNo { get; set; } = null!;
}
