using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Krka.MoveOn.Data;

/// <summary>
/// Class to store log entries in DB
/// </summary>
[Table("logs")]
[Serializable]
public class LogEntity
{
    /// <summary>
    /// Item ID
    /// </summary>
    [Required, Key]
    [Column("id")]
    public int Id { get; set; } = 0;

    /// <summary>
    /// Items importance or severity of log messages
    /// </summary>
    [Required]
    [Column("log_level", TypeName = "varchar"), StringLength(100)]
    public string? LogLevel { get; set; }

    /// <summary>
    /// Id of caller user
    /// </summary>
    [Required]
    [Column("id_user")]
    public int UserId { get; set; }

    /// <summary>
    /// Items source - class, ...
    /// </summary>
    [Required]
    [Column("category", TypeName = "varchar"), StringLength(100)]
    public string? Category { get; set; }

    /// <summary>
    /// Time of item creation
    /// </summary>
    [Required]
    [Column("created_at")]
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    /// <summary>
    /// Items source - class, ...
    /// </summary>
    [Required]
    [Column("message", TypeName = "nvarchar")]
    public string? Message { get; set; }
}
