using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Krka.MoveOn.Data.Questionnaires
{
    [Table("questionnaire_motorskill06")]
    public class QuestionnaireMotorSkill06
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("questionnaire_id", TypeName = "nvarchar"), StringLength(450)]
        public required string Questionnaire_id { get; set; }

        #region "Sec-motskill"

        /// <summary>
        /// Reč
        /// </summary>
        [Column("motskill_1")]
        public required int Motskill_1 { get; set; }

        /// <summary>
        /// Výraz tváre
        /// </summary>
        [Column("motskill_2")]
        public required int Motskill_2 { get; set; }

        /// <summary>
        /// Rigidita - krk
        /// </summary>
        [Column("motskill_3")]
        public required int Motskill_3 { get; set; }

        /// <summary>
        /// Rigidita - PHK
        /// </summary>
        [Column("motskill_4")]
        public required int Motskill_4 { get; set; }

        /// <summary>
        /// Rigidita - ĽHK
        /// </summary>
        [Column("motskill_5")]
        public required int Motskill_5 { get; set; }

        /// <summary>
        /// Rigidita - PDK
        /// </summary>
        [Column("motskill_6")]
        public required int Motskill_6 { get; set; }

        /// <summary>
        /// Rigidita - ĽDK
        /// </summary>
        [Column("motskill_7")]
        public required int Motskill_7 { get; set; }

        /// <summary>
        /// Spínanie prstov – P ruka
        /// </summary>
        [Column("motskill_8")]
        public required int Motskill_8 { get; set; }

        /// <summary>
        /// Spínanie prstov – Ľ ruka
        /// </summary>
        [Column("motskill_9")]
        public required int Motskill_9 { get; set; }

        /// <summary>
        /// Pohyby rúk – P ruka
        /// </summary>
        [Column("motskill_10")]
        public required int Motskill_10 { get; set; }

        /// <summary>
        /// Pohyby rúk – Ľ ruka
        /// </summary>
        [Column("motskill_11")]
        public required int Motskill_11 { get; set; }

        /// <summary>
        /// Supinačne-pronančné pohyby rúk – P ruka
        /// </summary>
        [Column("motskill_12")]
        public required int Motskill_12 { get; set; }

        /// <summary>
        /// Supinačne-pronančné pohyby rúk – Ľ ruka
        /// </summary>
        [Column("motskill_13")]
        public required int Motskill_13 { get; set; }

        /// <summary>
        /// Klopkanie špičkami nôh – P noha
        /// </summary>
        [Column("motskill_14")]
        public required int Motskill_14 { get; set; }

        /// <summary>
        /// Klopkanie špičkami nôh – Ľ noha
        /// </summary>
        [Column("motskill_15")]
        public required int Motskill_15 { get; set; }

        /// <summary>
        /// Obratnosť dolných končatín - PDK
        /// </summary>
        [Column("motskill_16")]
        public required int Motskill_16 { get; set; }

        /// <summary>
        /// Obratnosť dolných končatín - ĽDK
        /// </summary>
        [Column("motskill_17")]
        public required int Motskill_17 { get; set; }

        /// <summary>
        /// Vstávanie zo stoličky
        /// </summary>
        [Column("motskill_18")]
        public required int Motskill_18 { get; set; }

        /// <summary>
        /// Chôdza
        /// </summary>
        [Column("motskill_19")]
        public required int Motskill_19 { get; set; }

        /// <summary>
        /// Stuhnutie počas chôdze (freezing)
        /// </summary>
        [Column("motskill_20")]
        public required int Motskill_20 { get; set; }

        /// <summary>
        /// Posturálna stabilita
        /// </summary>
        [Column("motskill_21")]
        public required int Motskill_21 { get; set; }

        /// <summary>
        /// Postoj
        /// </summary>
        [Column("motskill_22")]
        public required int Motskill_22 { get; set; }

        /// <summary>
        /// Celková spontaneita pohybov (bradykinéza)
        /// </summary>
        [Column("motskill_23")]
        public required int Motskill_23 { get; set; }

        /// <summary>
        /// Polohový tras rúk – P ruka
        /// </summary>
        [Column("motskill_24")]
        public required int Motskill_24 { get; set; }

        /// <summary>
        /// Polohový tras rúk – Ľ ruka
        /// </summary>
        [Column("motskill_25")]
        public required int Motskill_25 { get; set; }

        /// <summary>
        /// Kinetický tras rúk – P ruka
        /// </summary>
        [Column("motskill_26")]
        public required int Motskill_26 { get; set; }

        /// <summary>
        /// Kinetický tras rúk – Ľ ruka
        /// </summary>
        [Column("motskill_27")]
        public required int Motskill_27 { get; set; }

        /// <summary>
        /// Amplitúda pokojového trasu - PHK
        /// </summary>
        [Column("motskill_28")]
        public required int Motskill_28 { get; set; }

        /// <summary>
        /// Amplitúda pokojového trasu - ĽHK
        /// </summary>
        [Column("motskill_29")]
        public required int Motskill_29 { get; set; }

        /// <summary>
        /// Amplitúda pokojového trasu - PDK
        /// </summary>
        [Column("motskill_30")]
        public required int Motskill_30 { get; set; }

        /// <summary>
        /// Amplitúda pokojového trasu - ĽDK
        /// </summary>
        [Column("motskill_31")]
        public required int Motskill_31 { get; set; }

        /// <summary>
        /// Amplitúda pokojového trasu – pery/sánka
        /// </summary>
        [Column("motskill_32")]
        public required int Motskill_32 { get; set; }

        /// <summary>
        /// Konštantnosť pokojového trasu
        /// </summary>
        [Column("motskill_33")]
        public required int Motskill_33 { get; set; }

        [Range(0, 100)]
        [Column("progress_percentage", TypeName = "int")]
        public int ProgressPercentage { get; set; } = 0;

        [Column("modified_at")]
        public required DateTime ModifiedAt { get; set; } = DateTime.Now;

        [Column("created_at")]
        public required DateTime CreatedAt { get; set; } = DateTime.Now;
        #endregion
    }
}
