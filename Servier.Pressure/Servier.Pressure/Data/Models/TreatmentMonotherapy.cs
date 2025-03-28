using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Servier.Pressure.Data.Lists;

namespace Servier.Pressure.Data.Models;

public enum VisitEnum
{
    before = 0,
    first = 1,
    second = 2
}

[Table("treatment_monotherapies")]
public class TreatmentMonotherapy
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("id_patient", TypeName = "nvarchar"), StringLength(450)]
    public required string PatientId { get; set; }
    [Column("visit_number")]
    public VisitEnum VisitNumber { get; set; }
    [Column("id_drug")]
    public int DrugId { get; set; } = 0;
    [Column("monotherapy")]
    public MonotherapyEnum Monotherapy { get; set; }
    [Column("is_aldosterone_antagonist")]
    public required bool IsAldosteroneAntagonist { get; set; } = false;

    [Column("dose")]
    public int Dose { get; set; } = 0;
    [Column("number_morning")]
    public int NumberMorning { get; set; } = 0;
    [Column("number_noon")]
    public int NumberNoon { get; set; } = 0;
    [Column("number_evening")]
    public int NumberEvening { get; set; } = 0;
    [Column("is_unknown")]
    public required bool IsUnknown { get; set; } = false;

    [Column("modified_at")]
    public required DateTime ModifiedAt { get; set; } = DateTime.Now;
    [Column("created_at")]
    public required DateTime CreatedAt { get; set; } = DateTime.Now;
}
