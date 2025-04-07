using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Servier.Pressure.Data.Models;

[Table("physical_examinations_2")]
public class PhysicalExamination2
{
    /// <summary>
    /// Relevant Patient Id used as key
    /// </summary>
    [Key]
    [Column("id", TypeName = "nvarchar"), StringLength(450)]
    public required string Id { get; set; }

    [Column("ambulatory_monitor")]
    public bool AmbulatoryMonitor { get; set; } = false;
    [Column("borrowed_monitor")]
    public bool BorrowedMonitor { get; set; } = false;

    [Column("a_hand")]
    public HandEnum AmbulatoryHand { get; set; }
    [Column("a_measurement_1")]
    public bool AmbulatoryMeasurement1 { get; set; } = false;
    [Column("a_measurement_1_stk")]
    public int AmbulatoryMeasurement1Stk { get; set; } = 0;
    [Column("a_measurement_1_dtk")]
    public int AmbulatoryMeasurement1Dtk { get; set; } = 0;
    [Column("a_measurement_1_sf")]
    public int AmbulatoryMeasurement1Sf { get; set; } = 0;
    [Column("a_measurement_2")]
    public bool AmbulatoryMeasurement2 { get; set; } = false;
    [Column("a_measurement_2_stk")]
    public int AmbulatoryMeasurement2Stk { get; set; } = 0;
    [Column("a_measurement_2_dtk")]
    public int AmbulatoryMeasurement2Dtk { get; set; } = 0;
    [Column("a_measurement_2_sf")]
    public int AmbulatoryMeasurement2Sf { get; set; } = 0;
    [Column("a_measurement_3")]
    public bool AmbulatoryMeasurement3 { get; set; } = false;
    [Column("a_measurement_3_stk")]
    public int AmbulatoryMeasurement3Stk { get; set; } = 0;
    [Column("a_measurement_3_dtk")]
    public int AmbulatoryMeasurement3Dtk { get; set; } = 0;
    [Column("a_measurement_3_sf")]
    public int AmbulatoryMeasurement3Sf { get; set; } = 0;

    [Column("b_hand")]
    public HandEnum BorrowedHand { get; set; }
    [Column("b_measurement_1")]
    public bool BorrowedMeasurement1 { get; set; } = false;
    [Column("b_measurement_1_stk")]
    public int BorrowedMeasurement1Stk { get; set; } = 0;
    [Column("b_measurement_1_dtk")]
    public int BorrowedMeasurement1Dtk { get; set; } = 0;
    [Column("b_measurement_1_sf")]
    public int BorrowedMeasurement1Sf { get; set; } = 0;
    [Column("b_measurement_2")]
    public bool BorrowedMeasurement2 { get; set; } = false;
    [Column("b_measurement_2_stk")]
    public int BorrowedMeasurement2Stk { get; set; } = 0;
    [Column("b_measurement_2_dtk")]
    public int BorrowedMeasurement2Dtk { get; set; } = 0;
    [Column("b_measurement_2_sf")]
    public int BorrowedMeasurement2Sf { get; set; } = 0;
    [Column("b_measurement_3")]
    public bool BorrowedMeasurement3 { get; set; } = false;
    [Column("b_measurement_3_stk")]
    public int BorrowedMeasurement3Stk { get; set; } = 0;
    [Column("b_measurement_3_dtk")]
    public int BorrowedMeasurement3Dtk { get; set; } = 0;
    [Column("b_measurement_3_sf")]
    public int BorrowedMeasurement3Sf { get; set; } = 0;

    [Column("modified_at")]
    public required DateTime ModifiedAt { get; set; } = DateTime.Now;
    [Column("created_at")]
    public required DateTime CreatedAt { get; set; } = DateTime.Now;
}
