using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Krka.MoveOn.Data.Questionnaires
{
    [Table("questionnaire_initial02")]
    public class QuestionnaireInitial02
    {
        [Key]
        [Column("id")]
        public required int Id { get; set; }

        [Column("questionnaire_id", TypeName = "nvarchar"), StringLength(450)]
        public required string Questionnaire_id { get; set; }

        /// <summary>
        /// 2. dotaznik Dátum
        /// </summary>
        [Column("init_date")]
        public DateTime InitDate { get; set; }

        /// <summary>
        /// Učinná látka - číselník na DialActiveIngredient !!!!!
        /// </summary>
        [Column("init_1")]
        public int? Init_1 { get; set; }

        /// <summary>
        /// dávka (mg)
        /// </summary>
        [Column("init_2", TypeName = "decimal(5,2)")]
        public decimal Init_2 { get; set; }

        /// <summary>
        /// počet dávok denne
        /// </summary>
        [Column("init_3")]
        public int? Init_3 { get; set; }

        /// <summary>
        /// denná dávka
        /// </summary>
        [Column("init_4", TypeName = "decimal(5,2)")]
        public decimal? Init_4 { get; set; }


        [Column("modified_at")]
        public required DateTime ModifiedAt { get; set; } = DateTime.Now;

        [Column("created_at")]
        public required DateTime CreatedAt { get; set; } = DateTime.Now;

        [Column("deleted_at")]
        public required DateTime? DeletedAt { get; set; } 


        public QuestionnaireInitial02 Clone()
        {
            return (QuestionnaireInitial02)MemberwiseClone();
        }

    }
}
