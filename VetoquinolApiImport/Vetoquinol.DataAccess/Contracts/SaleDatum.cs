namespace Vetoquinol.DataAccess.Contracts;

public partial class SaleDatum
{
    public int Id { get; set; }

    public int DistrId { get; set; }

    public int? CenterId { get; set; }

    public bool Rebate { get; set; }

    public decimal Quantity { get; set; }

    public decimal BasePrice { get; set; }

    public decimal SetDiscount { get; set; }

    public string? IdDef { get; set; }

    public string? ProductId { get; set; }

    public string? ProductName { get; set; }

    public string? ClientMasterId { get; set; }

    public string? ClientId { get; set; }

    public string ClientName { get; set; } = null!;

    public string? ClientName2 { get; set; }

    public string? ClientAddress { get; set; }

    public string? ClientAddress2 { get; set; }

    public string? ClientCity { get; set; }

    public string? ClientZip { get; set; }

    public string? ClientRegNo { get; set; }

    public string? ClientIco { get; set; }

    public string? OrderNo { get; set; }

    public string? BatchNo { get; set; } = null!;

    public DateTime? DeliveryDate { get; set; }
}
