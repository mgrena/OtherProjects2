using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Servier.Pressure.Data.Models;

[Table("day_records")]
public class DayRecord
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    /// <summary>
    /// Relevant Patient Id used as key
    /// </summary>
    [Column("id_patient", TypeName = "nvarchar"), StringLength(450)]
    public required string PatientId { get; set; }
    [Column("day_num")]
    public required int DayNumber { get; set; } = 1;

    [Column("morning_1_pressure")]
    public bool Morning1PressureUnknown { get; set; } = false;
    [Column("morning_1_pulse")]
    public bool Morning1PulseUnknown { get; set; } = false;
    [Column("morning_1_stk")]
    public int? Morning1Stk { get; set; }
    [Column("morning_1_dtk")]
    public int? Morning1Dtk { get; set; }
    [Column("morning_1_sf")]
    public int? Morning1Sf { get; set; }

    [Column("morning_2_pressure")]
    public bool Morning2PressureUnknown { get; set; } = false;
    [Column("morning_2_pulse")]
    public bool Morning2PulseUnknown { get; set; } = false;
    [Column("morning_2_stk")]
    public int? Morning2Stk { get; set; }
    [Column("morning_2_dtk")]
    public int? Morning2Dtk { get; set; }
    [Column("morning_2_sf")]
    public int? Morning2Sf { get; set; }

    [Column("evening_1_pressure")]
    public bool Evening1PressureUnknown { get; set; } = false;
    [Column("evening_1_pulse")]
    public bool Evening1PulseUnknown { get; set; } = false;
    [Column("evening_1_stk")]
    public int? Evening1Stk { get; set; }
    [Column("evening_1_dtk")]
    public int? Evening1Dtk { get; set; }
    [Column("evening_1_sf")]
    public int? Evening1Sf { get; set; }

    [Column("evening_2_pressure")]
    public bool Evening2PressureUnknown { get; set; } = false;
    [Column("evening_2_pulse")]
    public bool Evening2PulseUnknown { get; set; } = false;
    [Column("evening_2_stk")]
    public int? Evening2Stk { get; set; }
    [Column("evening_2_dtk")]
    public int? Evening2Dtk { get; set; }
    [Column("evening_2_sf")]
    public int? Evening2Sf { get; set; }

    [Column("modified_at")]
    public required DateTime ModifiedAt { get; set; } = DateTime.Now;
    [Column("created_at")]
    public required DateTime CreatedAt { get; set; } = DateTime.Now;
}
