using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Krka.MoveOn.Data.RelationalTables
{
    [Table("rel_Gen7Yes")]
    public class Gen7YesRelational
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("GenQuestId")]
        public int? GenQuestId { get; set; }

        /// <summary>
        ///   -Ak áno názov mediciny (číselnik na DialMedicines) !!!!!!!!!!
        /// </summary>
        [Column("gen_7_1_dm")]
        public int? Gen_7_1_DM { get; set; }

        /// <summary>
        ///  - Davka 
        /// </summary>
        [Column("gen_7_2", TypeName = "decimal(5,2)")]
        public decimal? Gen_7_2 { get; set; }

        /// <summary>
        /// - Dĺžka užívania v rokoch 
        /// </summary>
        [Column("gen_7_4", TypeName = "decimal(3,1)")]
        public decimal? Gen_7_4 { get; set; }

        /// <summary>
        /// Ak na Otazku 7 dá odpoveď ine (Názov Mediciny)
        /// </summary>
        [Column("gen_7_1_1", TypeName = "varchar"), StringLength(50)]
        public string? Gen_7_1_1 { get; set; }

        /// <summary>
        /// Ak na Otazku 7 dá odpoveď ine (Davka)
        /// </summary>
        [Column("gen_7_1_2", TypeName = "decimal(5,2)")]
        public decimal? Gen_7_1_2 { get; set; }

        /// <summary>
        ///  Ak na Otazku 7 dá odpoveď ine - ( Dĺžka užívania v rokoch )
        /// </summary>
        [Column("gen_7_1_4", TypeName = "decimal(3,1)")]
        public decimal? Gen_7_1_4 { get; set; }

        [Column("modified_at")]
        public  DateTime? ModifiedAt { get; set; } = DateTime.Now;

        [Column("created_at")]
        public  DateTime? CreatedAt { get; set; } = DateTime.Now;


        [Column("deleted_at")]
        public DateTime? DeletedAt { get; set; }
    }
}
