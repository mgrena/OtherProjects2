using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Krka.MoveOn.Migrations
{
    /// <inheritdoc />
    public partial class rework : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id_patient",
                table: "questionnaire_treatment03",
                newName: "questionnaire_id");

            migrationBuilder.RenameColumn(
                name: "id_patient",
                table: "questionnaire_satisfaction10",
                newName: "questionnaire_id");

            migrationBuilder.RenameColumn(
                name: "id_patient",
                table: "questionnaire_nonmotor04",
                newName: "questionnaire_id");

            migrationBuilder.RenameColumn(
                name: "id_patient",
                table: "questionnaire_motorskill06",
                newName: "questionnaire_id");

            migrationBuilder.RenameColumn(
                name: "id_patient",
                table: "questionnaire_motor05",
                newName: "questionnaire_id");

            migrationBuilder.RenameColumn(
                name: "id_patient",
                table: "questionnaire_moca07",
                newName: "questionnaire_id");

            migrationBuilder.RenameColumn(
                name: "id_patient",
                table: "questionnaire_initial02",
                newName: "questionnaire_id");

            migrationBuilder.RenameColumn(
                name: "id_patient",
                table: "questionnaire_general01",
                newName: "questionnaire_id");

            migrationBuilder.RenameColumn(
                name: "id_patient",
                table: "questionnaire_exclusion08",
                newName: "questionnaire_id");

            migrationBuilder.RenameColumn(
                name: "id_patient",
                table: "questionnaire_drug_effect09",
                newName: "questionnaire_id");

            migrationBuilder.RenameColumn(
                name: "id_user",
                table: "dial_units",
                newName: "type_q");

            migrationBuilder.RenameColumn(
                name: "id_user",
                table: "dial_symptoms",
                newName: "type_q");

            migrationBuilder.RenameColumn(
                name: "id_user",
                table: "dial_specialization",
                newName: "type_q");

            migrationBuilder.RenameColumn(
                name: "id_user",
                table: "dial_q_general",
                newName: "type_q");

            migrationBuilder.RenameColumn(
                name: "id_user",
                table: "dial_mhs",
                newName: "type_q");

            migrationBuilder.RenameColumn(
                name: "id_user",
                table: "dial_medicines",
                newName: "type_q");

            migrationBuilder.RenameColumn(
                name: "id_user",
                table: "dial_indications",
                newName: "type_q");

            migrationBuilder.RenameColumn(
                name: "id_user",
                table: "dial_exlusions",
                newName: "type_q");

            migrationBuilder.RenameColumn(
                name: "id_user",
                table: "dial_adverse_effects",
                newName: "type_q");

            migrationBuilder.RenameColumn(
                name: "id_user",
                table: "dial_active_ingredient",
                newName: "type_q");

            migrationBuilder.AlterColumn<string>(
                name: "id_user",
                table: "patients",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "questionnaires",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_patient = table.Column<int>(type: "int", nullable: false),
                    questionnaire_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    order_num = table.Column<int>(type: "int", nullable: false),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questionnaires", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "dial_q_general",
                columns: new[] { "id", "created_at", "modified_at", "Name", "type_q" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Muž", 1 },
                    { 2, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Žena", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "questionnaires");

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "questionnaire_id",
                table: "questionnaire_treatment03",
                newName: "id_patient");

            migrationBuilder.RenameColumn(
                name: "questionnaire_id",
                table: "questionnaire_satisfaction10",
                newName: "id_patient");

            migrationBuilder.RenameColumn(
                name: "questionnaire_id",
                table: "questionnaire_nonmotor04",
                newName: "id_patient");

            migrationBuilder.RenameColumn(
                name: "questionnaire_id",
                table: "questionnaire_motorskill06",
                newName: "id_patient");

            migrationBuilder.RenameColumn(
                name: "questionnaire_id",
                table: "questionnaire_motor05",
                newName: "id_patient");

            migrationBuilder.RenameColumn(
                name: "questionnaire_id",
                table: "questionnaire_moca07",
                newName: "id_patient");

            migrationBuilder.RenameColumn(
                name: "questionnaire_id",
                table: "questionnaire_initial02",
                newName: "id_patient");

            migrationBuilder.RenameColumn(
                name: "questionnaire_id",
                table: "questionnaire_general01",
                newName: "id_patient");

            migrationBuilder.RenameColumn(
                name: "questionnaire_id",
                table: "questionnaire_exclusion08",
                newName: "id_patient");

            migrationBuilder.RenameColumn(
                name: "questionnaire_id",
                table: "questionnaire_drug_effect09",
                newName: "id_patient");

            migrationBuilder.RenameColumn(
                name: "type_q",
                table: "dial_units",
                newName: "id_user");

            migrationBuilder.RenameColumn(
                name: "type_q",
                table: "dial_symptoms",
                newName: "id_user");

            migrationBuilder.RenameColumn(
                name: "type_q",
                table: "dial_specialization",
                newName: "id_user");

            migrationBuilder.RenameColumn(
                name: "type_q",
                table: "dial_q_general",
                newName: "id_user");

            migrationBuilder.RenameColumn(
                name: "type_q",
                table: "dial_mhs",
                newName: "id_user");

            migrationBuilder.RenameColumn(
                name: "type_q",
                table: "dial_medicines",
                newName: "id_user");

            migrationBuilder.RenameColumn(
                name: "type_q",
                table: "dial_indications",
                newName: "id_user");

            migrationBuilder.RenameColumn(
                name: "type_q",
                table: "dial_exlusions",
                newName: "id_user");

            migrationBuilder.RenameColumn(
                name: "type_q",
                table: "dial_adverse_effects",
                newName: "id_user");

            migrationBuilder.RenameColumn(
                name: "type_q",
                table: "dial_active_ingredient",
                newName: "id_user");

            migrationBuilder.AlterColumn<int>(
                name: "id_user",
                table: "patients",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);
        }
    }
}
