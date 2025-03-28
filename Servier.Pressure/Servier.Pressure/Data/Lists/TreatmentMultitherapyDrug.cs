using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Servier.Pressure.Data.Lists;

public enum MultitherapyEnum
{
    [Display(Name = "FIXNÉ KOMBINÁCIE 2 ANTIHYPERTENZÍV")]
    Antihypertensive2 = 1,
    [Display(Name = "FIXNÉ KOMBINÁCIE 3 ANTIHYPERTENZÍV")]
    Antihypertensive3 = 2,
    [Display(Name = "FIXNÉ KOMBINÁCIE ANTIHYPERTENZÍV A HYPOLIPIDEMÍK")]
    WithHypolypedidemic = 3
}

[Table("list_treatment_multitherapy_drugs")]
public class TreatmentMultitherapyDrug
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("multitherapy")]
    public required MultitherapyEnum Multitherapy { get; set; }
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
