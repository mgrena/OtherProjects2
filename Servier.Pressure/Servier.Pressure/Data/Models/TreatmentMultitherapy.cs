using Servier.Pressure.Data.Lists;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Servier.Pressure.Data.Models;

[Table("treatment_multitherapies")]
public class TreatmentMultitherapy
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
    [Column("multitherapy")]
    public MultitherapyEnum Multitherapy { get; set; }
    [Column("is_other")]
    public bool IsOther { get; set; } = false;
    [Column("other", TypeName = "nvarchar"), StringLength(250)]
    public string? Other { get; set; }

    [Column("dose_1")]
    public decimal Dose1 { get; set; } = 0;
    [Column("dose_2")]
    public decimal Dose2 { get; set; } = 0;
    [Column("dose_3")]
    public decimal Dose3 { get; set; } = 0;
    [Column("number_morning")]
    public decimal NumberMorning { get; set; } = 0;
    [Column("number_noon")]
    public decimal NumberNoon { get; set; } = 0;
    [Column("number_evening")]
    public decimal NumberEvening { get; set; } = 0;
    [Column("is_unknown")]
    public required bool IsUnknown { get; set; } = false;

    [Column("modified_at")]
    public required DateTime ModifiedAt { get; set; } = DateTime.Now;
    [Column("created_at")]
    public required DateTime CreatedAt { get; set; } = DateTime.Now;
}
