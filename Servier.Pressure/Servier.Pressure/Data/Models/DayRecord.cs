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

    [Column("measurement_1_pressure")]
    public bool MorningPressureUnknown { get; set; } = false;
    [Column("measurement_1_pulse")]
    public bool MorningPulseUnknown { get; set; } = false;
    [Column("measurement_1_stk")]
    public int? MorningStk { get; set; }
    [Column("measurement_1_dtk")]
    public int? MorningDtk { get; set; }
    [Column("measurement_1_sf")]
    public int? MorningSf { get; set; }

    [Column("measurement_2_pressure")]
    public bool EveningPressureUnknown { get; set; } = false;
    [Column("measurement_2_pulse")]
    public bool EveningPulseUnknown { get; set; } = false;
    [Column("measurement_2_stk")]
    public int? EveningStk { get; set; }
    [Column("measurement_2_dtk")]
    public int? EveningDtk { get; set; }
    [Column("measurement_2_sf")]
    public int? EveningSf { get; set; }

    [Column("modified_at")]
    public required DateTime ModifiedAt { get; set; } = DateTime.Now;
    [Column("created_at")]
    public required DateTime CreatedAt { get; set; } = DateTime.Now;
}
