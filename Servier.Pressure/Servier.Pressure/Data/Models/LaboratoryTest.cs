using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Servier.Pressure.Data.Models;

[Table("laboratory_tests")]
public class LaboratoryTest
{
    [Key]
    [Column("id", TypeName = "nvarchar"), StringLength(450)]
    public required string Id { get; set; }

    [Column("cholesterol", TypeName = "decimal(4,1)")]
    public decimal Cholesterol { get; set; } = 0;
    [Column("cholesterol_unknown")]
    public bool CholesterolUnknown { get; set; } = false;
    [Column("ldl", TypeName = "decimal(4,1)")]
    public decimal LDL { get; set; } = 0;
    [Column("ldl_unknown")]
    public bool LDLUnknown { get; set; } = false;
    [Column("hdl", TypeName = "decimal(4,1)")]
    public decimal HDL { get; set; } = 0;
    [Column("hdl_unknown")]
    public bool HDLUnknown { get; set; } = false;

    [Column("triglycerides", TypeName = "decimal(4,1)")]
    public decimal Triglycerides { get; set; } = 0;
    [Column("triglycerides_unknown")]
    public bool TriglyceridesUnknown { get; set; } = false;
    [Column("albumin", TypeName = "decimal(4,1)")]
    public decimal Albumin { get; set; } = 0;
    [Column("albumin_unknown")]
    public bool AlbuminUnknown { get; set; } = false;
    [Column("creatinine", TypeName = "decimal(4,1)")]
    public decimal Creatinine { get; set; } = 0;
    [Column("creatinine_unknown")]
    public bool CreatinineUnknown { get; set; } = false;
    [Column("glycemia", TypeName = "decimal(4,1)")]
    public decimal Glycemia { get; set; } = 0;
    [Column("glycemia_unknown")]
    public bool GlycemiaUnknown { get; set; } = false;

    [Column("modified_at")]
    public required DateTime ModifiedAt { get; set; } = DateTime.Now;
    [Column("created_at")]
    public required DateTime CreatedAt { get; set; } = DateTime.Now;
}
