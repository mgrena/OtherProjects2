using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Krka.MoveOn.Migrations
{
    /// <inheritdoc />
    public partial class Questionnaires : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "questionnaire_drug_effect09",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_patient = table.Column<int>(type: "int", nullable: false),
                    de_1 = table.Column<int>(type: "int", nullable: true),
                    de_2 = table.Column<int>(type: "int", nullable: true),
                    de_3 = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    de_4 = table.Column<int>(type: "int", nullable: true),
                    de_5 = table.Column<int>(type: "int", nullable: true),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questionnaire_drug_effect09", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "questionnaire_exclusion08",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_patient = table.Column<int>(type: "int", nullable: false),
                    exc_q = table.Column<int>(type: "int", nullable: true),
                    exc_1 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    exc_2 = table.Column<int>(type: "int", nullable: false),
                    exc_3 = table.Column<int>(type: "int", nullable: true),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questionnaire_exclusion08", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "questionnaire_general01",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_patient = table.Column<int>(type: "int", nullable: false),
                    gen_1 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    gen_2_dg = table.Column<int>(type: "int", nullable: false),
                    gen_3_dg = table.Column<int>(type: "int", nullable: false),
                    gen_4_dg = table.Column<int>(type: "int", nullable: false),
                    gen_5_dg = table.Column<int>(type: "int", nullable: false),
                    gen_6_dg = table.Column<int>(type: "int", nullable: false),
                    gen_7_dg = table.Column<int>(type: "int", nullable: false),
                    gen_7_1_dm = table.Column<int>(type: "int", nullable: false),
                    gen_7_2 = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    gen_7_3_du = table.Column<int>(type: "int", nullable: false),
                    gen_7_4 = table.Column<decimal>(type: "decimal(3,1)", nullable: false),
                    gen_7_1_1 = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    gen_7_1_2 = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    gen_7_1_3_du = table.Column<int>(type: "int", nullable: true),
                    gen_7_1_4 = table.Column<decimal>(type: "decimal(3,1)", nullable: false),
                    gen_8 = table.Column<int>(type: "int", nullable: false),
                    gen_9_ds = table.Column<int>(type: "int", nullable: false),
                    gen_10 = table.Column<int>(type: "int", nullable: false),
                    gen_10_1 = table.Column<int>(type: "int", nullable: true),
                    gen_11 = table.Column<int>(type: "int", nullable: false),
                    gen_12 = table.Column<int>(type: "int", nullable: false),
                    gen_13 = table.Column<int>(type: "int", nullable: false),
                    gen_13_1 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questionnaire_general01", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "questionnaire_initial02",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_patient = table.Column<int>(type: "int", nullable: false),
                    init_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    init_1 = table.Column<int>(type: "int", nullable: true),
                    init_2 = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    init_3 = table.Column<int>(type: "int", nullable: true),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questionnaire_initial02", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "questionnaire_moca07",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_patient = table.Column<int>(type: "int", nullable: false),
                    moca_1 = table.Column<int>(type: "int", nullable: false),
                    moca_2 = table.Column<int>(type: "int", nullable: false),
                    moca_3 = table.Column<int>(type: "int", nullable: false),
                    moca_4 = table.Column<int>(type: "int", nullable: false),
                    moca_5 = table.Column<int>(type: "int", nullable: false),
                    moca_6 = table.Column<int>(type: "int", nullable: false),
                    moca_7 = table.Column<int>(type: "int", nullable: false),
                    moca_8 = table.Column<int>(type: "int", nullable: false),
                    moca_9 = table.Column<int>(type: "int", nullable: false),
                    moca_10 = table.Column<int>(type: "int", nullable: false),
                    moca_11 = table.Column<int>(type: "int", nullable: false),
                    moca_12 = table.Column<int>(type: "int", nullable: false),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questionnaire_moca07", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "questionnaire_motor05",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_patient = table.Column<int>(type: "int", nullable: false),
                    mot_1 = table.Column<int>(type: "int", nullable: false),
                    mot_2 = table.Column<int>(type: "int", nullable: false),
                    mot_3 = table.Column<int>(type: "int", nullable: false),
                    mot_4 = table.Column<int>(type: "int", nullable: false),
                    mot_5 = table.Column<int>(type: "int", nullable: false),
                    mot_6 = table.Column<int>(type: "int", nullable: false),
                    mot_7 = table.Column<int>(type: "int", nullable: false),
                    mot_8 = table.Column<int>(type: "int", nullable: false),
                    mot_9 = table.Column<int>(type: "int", nullable: false),
                    mot_10 = table.Column<int>(type: "int", nullable: false),
                    mot_11 = table.Column<int>(type: "int", nullable: false),
                    mot_12 = table.Column<int>(type: "int", nullable: false),
                    mot_13 = table.Column<int>(type: "int", nullable: false),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questionnaire_motor05", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "questionnaire_motorskill06",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_patient = table.Column<int>(type: "int", nullable: false),
                    motskill_1 = table.Column<int>(type: "int", nullable: false),
                    motskill_2 = table.Column<int>(type: "int", nullable: false),
                    motskill_3 = table.Column<int>(type: "int", nullable: false),
                    motskill_4 = table.Column<int>(type: "int", nullable: false),
                    motskill_5 = table.Column<int>(type: "int", nullable: false),
                    motskill_6 = table.Column<int>(type: "int", nullable: false),
                    motskill_7 = table.Column<int>(type: "int", nullable: false),
                    motskill_8 = table.Column<int>(type: "int", nullable: false),
                    motskill_9 = table.Column<int>(type: "int", nullable: false),
                    motskill_10 = table.Column<int>(type: "int", nullable: false),
                    motskill_11 = table.Column<int>(type: "int", nullable: false),
                    motskill_12 = table.Column<int>(type: "int", nullable: false),
                    motskill_13 = table.Column<int>(type: "int", nullable: false),
                    motskill_14 = table.Column<int>(type: "int", nullable: false),
                    motskill_15 = table.Column<int>(type: "int", nullable: false),
                    motskill_16 = table.Column<int>(type: "int", nullable: false),
                    motskill_17 = table.Column<int>(type: "int", nullable: false),
                    motskill_18 = table.Column<int>(type: "int", nullable: false),
                    motskill_19 = table.Column<int>(type: "int", nullable: false),
                    motskill_20 = table.Column<int>(type: "int", nullable: false),
                    motskill_21 = table.Column<int>(type: "int", nullable: false),
                    motskill_22 = table.Column<int>(type: "int", nullable: false),
                    motskill_23 = table.Column<int>(type: "int", nullable: false),
                    motskill_24 = table.Column<int>(type: "int", nullable: false),
                    motskill_25 = table.Column<int>(type: "int", nullable: false),
                    motskill_26 = table.Column<int>(type: "int", nullable: false),
                    motskill_27 = table.Column<int>(type: "int", nullable: false),
                    motskill_28 = table.Column<int>(type: "int", nullable: false),
                    motskill_29 = table.Column<int>(type: "int", nullable: false),
                    motskill_30 = table.Column<int>(type: "int", nullable: false),
                    motskill_31 = table.Column<int>(type: "int", nullable: false),
                    motskill_32 = table.Column<int>(type: "int", nullable: false),
                    motskill_33 = table.Column<int>(type: "int", nullable: false),
                    mh_1 = table.Column<int>(type: "int", nullable: true),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questionnaire_motorskill06", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "questionnaire_nonmotor04",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_patient = table.Column<int>(type: "int", nullable: false),
                    nonmot_1 = table.Column<int>(type: "int", nullable: false),
                    nonmot_2 = table.Column<int>(type: "int", nullable: false),
                    nonmot_3 = table.Column<int>(type: "int", nullable: false),
                    nonmot_4 = table.Column<int>(type: "int", nullable: false),
                    nonmot_5 = table.Column<int>(type: "int", nullable: false),
                    nonmot_6 = table.Column<int>(type: "int", nullable: false),
                    nonmot_7 = table.Column<int>(type: "int", nullable: false),
                    nonmot_8 = table.Column<int>(type: "int", nullable: false),
                    nonmot_9 = table.Column<int>(type: "int", nullable: false),
                    nonmot_10 = table.Column<int>(type: "int", nullable: false),
                    nonmot_11 = table.Column<int>(type: "int", nullable: false),
                    nonmot_12 = table.Column<int>(type: "int", nullable: false),
                    nonmot_13 = table.Column<int>(type: "int", nullable: false),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questionnaire_nonmotor04", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "questionnaire_satisfaction10",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_patient = table.Column<int>(type: "int", nullable: false),
                    sf_1 = table.Column<int>(type: "int", nullable: false),
                    sf_2 = table.Column<int>(type: "int", nullable: false),
                    sf_3 = table.Column<int>(type: "int", nullable: false),
                    sf_4 = table.Column<int>(type: "int", nullable: false),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questionnaire_satisfaction10", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "questionnaire_treatment03",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_patient = table.Column<int>(type: "int", nullable: false),
                    treat_q_1 = table.Column<int>(type: "int", nullable: true),
                    treat_1 = table.Column<int>(type: "int", nullable: true),
                    treat_2 = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    treat_3 = table.Column<int>(type: "int", nullable: true),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questionnaire_treatment03", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "questionnaire_drug_effect09");

            migrationBuilder.DropTable(
                name: "questionnaire_exclusion08");

            migrationBuilder.DropTable(
                name: "questionnaire_general01");

            migrationBuilder.DropTable(
                name: "questionnaire_initial02");

            migrationBuilder.DropTable(
                name: "questionnaire_moca07");

            migrationBuilder.DropTable(
                name: "questionnaire_motor05");

            migrationBuilder.DropTable(
                name: "questionnaire_motorskill06");

            migrationBuilder.DropTable(
                name: "questionnaire_nonmotor04");

            migrationBuilder.DropTable(
                name: "questionnaire_satisfaction10");

            migrationBuilder.DropTable(
                name: "questionnaire_treatment03");
        }
    }
}
