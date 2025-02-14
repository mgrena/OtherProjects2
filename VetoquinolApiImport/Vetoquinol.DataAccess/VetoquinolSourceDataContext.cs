using System;
using System.Collections.Generic;
using Vetoquinol.DataAccess.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Vetoquinol.DataAccess;

public partial class VetoquinolSourceDataContext : DbContext
{
    public VetoquinolSourceDataContext()
    {
    }

    public VetoquinolSourceDataContext(DbContextOptions<VetoquinolSourceDataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Distributor> Distributors { get; set; } = null!;

    public virtual DbSet<Pharmacy> Pharmacies { get; set; } = null!;

    public virtual DbSet<Product> Products { get; set; } = null!;

    public virtual DbSet<SaleDatum> SaleData { get; set; } = null!;

    public virtual DbSet<Stock> Stocks { get; set; } = null!;

    public virtual DbSet<VMedArtSk> VMedArtSks { get; set; } = null!;

    public virtual DbSet<VNovikoCz> VNovikoCzs { get; set; } = null!;

    public virtual DbSet<VPharmacopolaSk> VPharmacopolaSks { get; set; } = null!;

    public virtual DbSet<VSamohylCz> VSamohylCzs { get; set; } = null!;

    public virtual DbSet<VSgvetCz> VSgvetCzs { get; set; } = null!;

    public virtual DbSet<VTopvetSk> VTopvetSks { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseLazyLoadingProxies().UseSqlServer(DataAccessSettings.DBConnectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Distributor>(entity =>
        {
            entity.ToTable("Distributor");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Country)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("country");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Pharmacy>(entity =>
        {
            entity.ToTable("Pharmacy");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.Address2).HasMaxLength(150);
            entity.Property(e => e.CenterCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.ClientId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClientMasterId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ico)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.Name2).HasMaxLength(150);
            entity.Property(e => e.Phone)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PreviousMasterId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RegName).HasMaxLength(100);
            entity.Property(e => e.RegNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ZipCode)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Product");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AssortmentName).HasMaxLength(100);
            entity.Property(e => e.CatalogPrice).HasColumnType("decimal(7, 2)");
            entity.Property(e => e.CenterCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ean)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Finished)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.PackNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProducerName).HasMaxLength(100);
            entity.Property(e => e.ProductId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RegNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Vat)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("VAT");
            entity.Property(e => e.VendorProductId)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SaleDatum>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BasePrice).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.BatchNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClientAddress).HasMaxLength(150);
            entity.Property(e => e.ClientAddress2).HasMaxLength(150);
            entity.Property(e => e.ClientCity).HasMaxLength(50);
            entity.Property(e => e.ClientIco)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClientId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClientMasterId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClientName).HasMaxLength(150);
            entity.Property(e => e.ClientName2).HasMaxLength(150);
            entity.Property(e => e.ClientRegNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ClientZip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ClientZIP");
            entity.Property(e => e.DeliveryDate).HasColumnType("date");
            entity.Property(e => e.IdDef)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.OrderNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProductId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProductName).HasMaxLength(150);
            entity.Property(e => e.Quantity).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.SetDiscount).HasColumnType("decimal(9, 2)");
        });

        modelBuilder.Entity<Stock>(entity =>
        {
            entity.ToTable("Stock");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BatchNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Expiration).HasColumnType("datetime");
            entity.Property(e => e.ProductId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ReservedQtyOnStockLevel).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.StockLevel).HasColumnType("decimal(9, 2)");
        });

        modelBuilder.Entity<VMedArtSk>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_MedArt_sk");

            entity.Property(e => e.BasePrice).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.CatalogPrice).HasColumnType("decimal(7, 2)");
            entity.Property(e => e.ClientAddress).HasMaxLength(150);
            entity.Property(e => e.ClientCity).HasMaxLength(50);
            entity.Property(e => e.ClientZip).HasMaxLength(10);
            entity.Property(e => e.ClientIco)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClientId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClientName).HasMaxLength(150);
            entity.Property(e => e.DeliveryDate).HasColumnType("date");
            entity.Property(e => e.ProductName).HasMaxLength(150);
            entity.Property(e => e.ProductId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Quantity).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.SetDiscount).HasColumnType("decimal(9, 2)");
        });

        modelBuilder.Entity<VNovikoCz>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Noviko_cz");

            entity.Property(e => e.BasePrice).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.BatchNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CatalogPrice).HasColumnType("decimal(7, 2)");
            entity.Property(e => e.ClientAddress).HasMaxLength(150);
            entity.Property(e => e.ClientCity).HasMaxLength(50);
            entity.Property(e => e.ClientIco)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClientId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClientMasterId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClientName).HasMaxLength(150);
            entity.Property(e => e.ClientZip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ClientZIP");
            entity.Property(e => e.DeliveryDate).HasColumnType("date");
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.OrderNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProductId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Quantity).HasColumnType("decimal(9, 2)");
        });

        modelBuilder.Entity<VPharmacopolaSk>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Pharmacopola_sk");

            entity.Property(e => e.BasePrice).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.CatalogPrice).HasColumnType("decimal(7, 2)");
            entity.Property(e => e.ClientAddress).HasMaxLength(150);
            entity.Property(e => e.ClientAddress2).HasMaxLength(150);
            entity.Property(e => e.ClientCity).HasMaxLength(50);
            entity.Property(e => e.ClientId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClientName).HasMaxLength(150);
            entity.Property(e => e.ClientName2).HasMaxLength(150);
            entity.Property(e => e.ClientRegNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ClientZip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ClientZIP");
            entity.Property(e => e.DeliveryDate).HasColumnType("date");
            entity.Property(e => e.ProductId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProductName).HasMaxLength(150);
            entity.Property(e => e.Quantity).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.SetDiscount).HasColumnType("decimal(9, 2)");
        });

        modelBuilder.Entity<VSamohylCz>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Samohyl_cz");

            entity.Property(e => e.BasePrice).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.ClientAddress).HasMaxLength(150);
            entity.Property(e => e.ClientAddress2).HasMaxLength(150);
            entity.Property(e => e.ClientCity).HasMaxLength(50);
            entity.Property(e => e.ClientId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClientMasterId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClientName).HasMaxLength(150);
            entity.Property(e => e.ClientName2).HasMaxLength(150);
            entity.Property(e => e.ClientRegNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ClientZip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ClientZIP");
            entity.Property(e => e.DeliveryDate).HasColumnType("date");
            entity.Property(e => e.OrderNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProductId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProductName).HasMaxLength(150);
            entity.Property(e => e.Quantity).HasColumnType("decimal(9, 2)");
        });

        modelBuilder.Entity<VSgvetCz>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_SGVet_cz");

            entity.Property(e => e.BasePrice).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.BatchNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CatalogPrice).HasColumnType("decimal(7, 2)");
            entity.Property(e => e.ClientAddress).HasMaxLength(150);
            entity.Property(e => e.ClientCity).HasMaxLength(50);
            entity.Property(e => e.ClientIco)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClientId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClientMasterId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClientName).HasMaxLength(150);
            entity.Property(e => e.ClientZip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ClientZIP");
            entity.Property(e => e.DeliveryDate).HasColumnType("date");
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.OrderNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProductId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Quantity).HasColumnType("decimal(9, 2)");
        });

        modelBuilder.Entity<VTopvetSk>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Topvet_sk");

            entity.Property(e => e.BasePrice).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.CatalogPrice).HasColumnType("decimal(7, 2)");
            entity.Property(e => e.ClientAddress).HasMaxLength(150);
            entity.Property(e => e.ClientCity).HasMaxLength(50);
            entity.Property(e => e.ClientZip).HasMaxLength(10);
            entity.Property(e => e.ClientIco)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClientId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClientName).HasMaxLength(150);
            entity.Property(e => e.DeliveryDate).HasColumnType("date");
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.ProductId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Quantity).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.SetDiscount).HasColumnType("decimal(9, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
