using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Servier.Pressure.Data.Models;

public enum HandEnum
{
    [Display(Name = "pravá ruka")]
    right = 1,
    [Display(Name = "ľavá ruka")]
    left = 2
}

[Table("physical_examinations_1")]
public class PhysicalExamination1
{
    /// <summary>
    /// Relevant Patient Id used as key
    /// </summary>
    [Key]
    [Column("id", TypeName = "nvarchar"), StringLength(450)]
    public required string Id { get; set; }

    [Column("height", TypeName = "decimal(4,1)")]
    public decimal Height { get; set; } = 0;
    [Column("height_unknown")]
    public bool HeightUnknown { get; set; } = false;
    [Column("weight", TypeName = "decimal(4,1)")]
    public decimal Weight { get; set; } = 0;
    [Column("weight_unknown")]
    public bool WeightUnknown { get; set; } = false;
    [Column("waist", TypeName = "decimal(4,1)")]
    public decimal Waist { get; set; } = 0;
    [Column("waist_unknown")]
    public bool WaistUnknown { get; set; } = false;
    [Column("hand")]
    public HandEnum Hand { get; set; }

    [Column("measurement_1")]
    public bool Measurement1 { get; set; } = false;
    [Column("measurement_1_stk")]
    public int Measurement1Stk { get; set; } = 0;
    [Column("measurement_1_dtk")]
    public int Measurement1Dtk { get; set; } = 0;
    [Column("measurement_1_sf")]
    public int Measurement1Sf { get; set; } = 0;
    [Column("measurement_2")]
    public bool Measurement2 { get; set; } = false;
    [Column("measurement_2_stk")]
    public int Measurement2Stk { get; set; } = 0;
    [Column("measurement_2_dtk")]
    public int Measurement2Dtk { get; set; } = 0;
    [Column("measurement_2_sf")]
    public int Measurement2Sf { get; set; } = 0;
    [Column("measurement_3")]
    public bool Measurement3 { get; set; } = false;
    [Column("measurement_3_stk")]
    public int Measurement3Stk { get; set; } = 0;
    [Column("measurement_3_dtk")]
    public int Measurement3Dtk { get; set; } = 0;
    [Column("measurement_3_sf")]
    public int Measurement3Sf { get; set; } = 0;

    [Column("modified_at")]
    public required DateTime ModifiedAt { get; set; } = DateTime.Now;
    [Column("created_at")]
    public required DateTime CreatedAt { get; set; } = DateTime.Now;
}
