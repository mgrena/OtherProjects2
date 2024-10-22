using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Krka.MoveOn.Data.AdverseEffects
{
    [Table("adverse_effects")]
    public class AdverseEffect
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("id_questionnaire")]
        public required int QuestionnaireId { get; set; }

        /// <summary>
        /// Nežiaduca udalosť 
        /// </summary>
        [Column("adverse_effect",TypeName = "nvarchar"), StringLength(150)]
        public string? Name { get; set; }

        /// <summary>
        /// Začiatok
        /// </summary>
        [Column("start")]
        public int? Start { get; set; }

        /// <summary>
        /// Frekvencia
        /// </summary>
        [Column("frequency")]
        public int? Frequency { get; set; }

        /// <summary>
        /// Súvis
        /// </summary>
        [Column("related")]
        public int? Related { get; set; }

        /// <summary>
        /// Zavaznost
        /// </summary>
        [Column("severity")]
        public int? Severity { get; set; }

        /// <summary>
        /// Intenzita
        /// </summary>
        [Column("intensity")]
        public int? Intensity { get; set; }

        /// <summary>
        /// Vplyv na liečbu
        /// </summary>
        [Column("effect")]
        public int? Effect { get; set; }

        /// <summary>
        /// vysledok
        /// </summary>
        [Column("result")]
        public int? Result { get; set; }

        [Column("modified_at")]
        public DateTime ModifiedAt { get; set; } = DateTime.Now;

        [Column("created_at")]
        public  DateTime CreatedAt { get; set; } = DateTime.Now;

        [Column("deleted_at")]
        public  DateTime? DeletedAt { get; set; }
    }
}
