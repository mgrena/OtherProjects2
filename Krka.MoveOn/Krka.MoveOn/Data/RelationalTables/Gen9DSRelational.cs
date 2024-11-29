using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Krka.MoveOn.Data.RelationalTables
{
    [Table("rel_Gen9DS")]
    public class Gen9DSRelational
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("GenQuestId")]
        public int? GenQuestId { get; set; }

        [Column("Gen9DS_Answer_Id")]
        public int? Gen9DSAnswerId { get; set; }

        [Column("modified_at")]
        public  DateTime? ModifiedAt { get; set; } = DateTime.Now;

        [Column("created_at")]
        public  DateTime? CreatedAt { get; set; } = DateTime.Now;
    }
}
