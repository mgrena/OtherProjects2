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

    [Column("dose_1")]
    public int Dose1 { get; set; } = 0;
    [Column("dose_2")]
    public int Dose2 { get; set; } = 0;
    [Column("dose_3")]
    public int Dose3 { get; set; } = 0;
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
