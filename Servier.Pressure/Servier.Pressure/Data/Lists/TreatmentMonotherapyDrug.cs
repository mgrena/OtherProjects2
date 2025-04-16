using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Servier.Pressure.Data.Lists;

public enum MonotherapyEnum
{
    [Display(Name = "ACE inhibítor")]
    ACEInhibitor = 1,
    [Display(Name = "blokátor receptora angiotenzínu II")]
    AngiotensinIIReceptorBlocker = 2,
    [Display(Name = "blokátor kalciového kanála")]
    CalciumChannelBlocker = 3,
    [Display(Name = "beta blokátor")]
    BetaBlocker = 4,
    [Display(Name = "diuretikum")]
    Diuretic = 5,
    [Display(Name = "antagonista aldosterónu")]
    AldosteroneAntagonist = 6,
    [Display(Name = "iné")]
    Other = 7
}

[Table("list_treatment_monotherapy_drugs")]
public class TreatmentMonotherapyDrug
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("monotherapy")]
    public required MonotherapyEnum Monotherapy { get; set; }
    [Column("order_number")]
    public required int Order { get; set; } = 0;
    [Column("drug", TypeName = "nvarchar"), StringLength(255)]
    public required string Name { get; set; } = string.Empty;

    [Column("created_at")]
    public required DateTime CreatedAt { get; set; } = DateTime.Now;
    [Column("modified_at")]
    public required DateTime ModifiedAt { get; set; } = DateTime.Now;
    [Column("deleted_at")]
    public DateTime? DeletedAt { get; set; }
}
