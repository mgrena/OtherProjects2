using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Krka.MoveOn.Data;

public class WorkPlace
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    [Column("workplace", TypeName = "nvarchar"), StringLength(255)]
    public required string Workplace { get; set; }
    [Column("created_at")]
    public required DateTime CreatedAt { get; set; } = DateTime.Now;
    [Column("deleted_at")]
    public DateTime? DeletedAt { get; set; }
}
