using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Krka.MoveOn.Data.Questionnaires
{

    [Table("questionnaire_motor05")]
    public class QuestionnaireMotor05
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("questionnaire_id", TypeName = "nvarchar"), StringLength(450)]
        public required string Questionnaire_id { get; set; }

        /// <summary>
        /// Reč
        /// </summary>
        [Column("mot_1")]
        public required int Mot_1 { get; set; }

        /// <summary>
        /// Slinenie
        /// </summary>
        [Column("mot_2")]
        public required int Mot_2 { get; set; }

        /// <summary>
        /// Žuvanie a prehĺtanie
        /// </summary>
        [Column("mot_3")]
        public required int Mot_3 { get; set; }

        /// <summary>
        /// Príprava jedla a stolovanie
        /// </summary>
        [Column("mot_4")]
        public required int Mot_4 { get; set; }

        /// <summary>
        /// Obliekanie sa
        /// </summary>
        [Column("mot_5")]
        public required int Mot_5 { get; set; }

        /// <summary>
        /// Hygiena
        /// </summary>
        [Column("mot_6")]
        public required int Mot_6 { get; set; }

        /// <summary>
        /// Písanie
        /// </summary>
        [Column("mot_7")]
        public required int Mot_7 { get; set; }

        /// <summary>
        /// Koníčky a iné aktivity
        /// </summary>
        [Column("mot_8")]
        public required int Mot_8 { get; set; }

        /// <summary>
        /// Pohyblivosť v posteli
        /// </summary>
        [Column("mot_9")]
        public required int Mot_9 { get; set; }

        /// <summary>
        /// Tras
        /// </summary>
        [Column("mot_10")]
        public required int Mot_10 { get; set; }

        /// <summary>
        /// Vstávanie z postele, auta alebo hlbokej stoličky
        /// </summary>
        [Column("mot_11")]
        public required int Mot_11 { get; set; }

        /// <summary>
        /// Chôdza a rovnováha
        /// </summary>
        [Column("mot_12")]
        public required int Mot_12 { get; set; }

        /// <summary>
        /// Stuhnutie pohybu počas chôdze (freezing)
        /// </summary>
        [Column("mot_13")]
        public required int Mot_13 { get; set; }

        [Range(0, 100)]
        [Column("progress_percentage", TypeName = "int")]
        public int ProgressPercentage { get; set; } = 0;

        [Column("modified_at")]
        public required DateTime ModifiedAt { get; set; } = DateTime.Now;

        [Column("created_at")]
        public required DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
