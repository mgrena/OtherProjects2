using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Krka.MoveOn.Data.AdverseEffects
{
    [Table("adverse_effects")]
    public class AdverseEffect
    {
        [Key]
        [Column("id")]
        public required int Id { get; set; }

        [Column("id_questionnaire")]
        public required int QuestionnaireId { get; set; }

        /// <summary>
        /// Nežiaduca udalosť 
        /// </summary>
        [Column("adverse_effect",TypeName = "nvarchar"), StringLength(50)]
        public required string Name { get; set; }

        /// <summary>
        /// Začiatok
        /// </summary>
        [Column("start")]
        public required int Start { get; set; }

        /// <summary>
        /// Frekvencia
        /// </summary>
        [Column("frequency")]
        public required int Frequency { get; set; }

        /// <summary>
        /// Súvis
        /// </summary>
        [Column("related")]
        public required int Related { get; set; }

        /// <summary>
        /// Súvis
        /// </summary>
        [Column("severity")]
        public required int Severity { get; set; }

        /// <summary>
        /// Intenzita
        /// </summary>
        [Column("intensity")]
        public required int Intensity { get; set; }

        /// <summary>
        /// Vplyv na liečbu
        /// </summary>
        [Column("effect")]
        public required int Effect { get; set; }

        /// <summary>
        /// Vplyv na liečbu
        /// </summary>
        [Column("result")]
        public required int Result { get; set; }

        [Column("modified_at")]
        public required DateTime ModifiedAt { get; set; } = DateTime.Now;

        [Column("created_at")]
        public required DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
