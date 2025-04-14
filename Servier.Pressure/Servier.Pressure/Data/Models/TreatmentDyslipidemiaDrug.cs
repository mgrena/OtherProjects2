using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Servier.Pressure.Data.Models;

[Table("treatment_dyslipidemia_drugs")]
public class TreatmentDyslipidemiaDrug
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    [Column("id_drug")]
    public int DrugId { get; set; }
    [Column("id_patient", TypeName = "nvarchar"), StringLength(450)]
    public required string PatientId { get; set; }

    [Column("created_at")]
    public required DateTime CreatedAt { get; set; } = DateTime.Now;
}
