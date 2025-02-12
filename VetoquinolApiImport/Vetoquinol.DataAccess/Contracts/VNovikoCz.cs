using System;
using System.Collections.Generic;

namespace Vetoquinol.DataAccess.Contracts;

public partial class VNovikoCz
{
    public bool Rebate { get; set; }

    public decimal Quantity { get; set; }

    public decimal BasePrice { get; set; }

    public string? ProductId { get; set; }

    public string? DistrProductId { get; set; }

    public string? VetoquinolProductId { get; set; }

    public string Name { get; set; } = null!;

    public decimal CatalogPrice { get; set; }

    public bool Available { get; set; }

    public string? ClientMasterId { get; set; }

    public string? ClientId { get; set; }

    public string ClientName { get; set; } = null!;

    public string? ClientAddress { get; set; }

    public string? ClientCity { get; set; }

    public string? ClientZip { get; set; }

    public string? ClientIco { get; set; }

    public string? BatchNo { get; set; }

    public string? OrderNo { get; set; }

    public DateTime? DeliveryDate { get; set; }
}
