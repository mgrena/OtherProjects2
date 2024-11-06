using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Krka.MoveOn.Data.Questionnaires
{
    [Table("questionnaire_nonmotor04")]
    public class QuestionnaireNonMotor04
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("questionnaire_id", TypeName = "nvarchar"), StringLength(450)]
        public required string Questionnaire_id { get; set; }

        /// <summary>
        /// Zhoršenie kognitívnych funkcií
        /// </summary>
        [Column("nonmot_1")]
        public required int Nonmot_1 { get; set; }

        /// <summary>
        /// Halucinácie a psychózy
        /// </summary>
        [Column("nonmot_2")]
        public required int Nonmot_2 { get; set; }

        /// <summary>
        /// Depresívna nálada
        /// </summary>
        [Column("nonmot_3")]
        public required int Nonmot_3 { get; set; }

        /// <summary>
        /// Úzkostná nálada
        /// </summary>
        [Column("nonmot_4")]
        public required int Nonmot_4 { get; set; }

        /// <summary>
        /// Apatia
        /// </summary>
        [Column("nonmot_5")]
        public required int Nonmot_5 { get; set; }

        /// <summary>
        /// Prejavy syndrómu dopamínovejdysregulácie
        /// </summary>
        [Column("nonmot_6")]
        public required int Nonmot_6 { get; set; }

        /// <summary>
        /// Problémy so spánkom
        /// </summary>
        [Column("nonmot_7")]
        public required int Nonmot_7 { get; set; }

        /// <summary>
        /// Denná spavosť
        /// </summary>
        [Column("nonmot_8")]
        public required int Nonmot_8 { get; set; }

        /// <summary>
        /// Bolesť a iné poruchy citlivosti
        /// </summary>
        [Column("nonmot_9")]
        public required int Nonmot_9 { get; set; }

        /// <summary>
        /// Problémy s močením
        /// </summary>
        [Column("nonmot_10")]
        public required int Nonmot_10 { get; set; }

        /// <summary>
        /// Problémy so zápchou
        /// </summary>
        [Column("nonmot_11")]
        public required int Nonmot_11 { get; set; }

        /// <summary>
        /// Závrativosť pri zmene polohy tela
        /// </summary>
        [Column("nonmot_12")]
        public required int Nonmot_12 { get; set; }

        /// <summary>
        /// Únava
        /// </summary>
        [Column("nonmot_13")]
        public required int Nonmot_13 { get; set; }


        [Column("modified_at")]
        public required DateTime ModifiedAt { get; set; } = DateTime.Now;

        [Column("created_at")]
        public required DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
