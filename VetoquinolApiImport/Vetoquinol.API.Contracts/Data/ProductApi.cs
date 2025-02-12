namespace Vetoquinol.API.Contracts.Data;

public class ProductApi
{
    public int Id { get; set; }
    public int DistrId { get; set; }
    public int? ProductIdInt { get; set; }
    public string? ProductId { get; set; }
    public string? VendorProductId { get; set; }
    public string? Code { get; set; }
    public string? Name { get; set; }
    public decimal VAT { get; set; }
    public decimal CatalogPrice { get; set; }
    public int CenterId { get; set; }
    public string? CenterCode { get; set; }
    public string? Ean { get; set; }
    public string? ProducerName { get; set; }
    public string? AssortmentName { get; set; }
    public string? RegNumber { get; set; }
    public string? PackNumber { get; set; }
    public string? Finished { get; set; }
    public bool Available { get; set; }
}
