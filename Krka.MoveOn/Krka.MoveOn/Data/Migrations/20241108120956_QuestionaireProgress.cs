using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Krka.MoveOn.Migrations
{
    /// <inheritdoc />
    public partial class QuestionaireProgress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "progress_percentage",
                table: "questionnaires",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "progress_percentage",
                table: "questionnaire_satisfaction10",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "progress_percentage",
                table: "questionnaire_nonmotor04",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "progress_percentage",
                table: "questionnaire_motorskill06",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "progress_percentage",
                table: "questionnaire_motor05",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "progress_percentage",
                table: "questionnaire_moca07",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "progress_percentage",
                table: "questionnaire_general01",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "progress_percentage",
                table: "questionnaire_exclusion08",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "entry_progress_percentage",
                table: "patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ongoing_progress_percentage",
                table: "patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "result_progress_percentage",
                table: "patients",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "progress_percentage",
                table: "questionnaires");

            migrationBuilder.DropColumn(
                name: "progress_percentage",
                table: "questionnaire_satisfaction10");

            migrationBuilder.DropColumn(
                name: "progress_percentage",
                table: "questionnaire_nonmotor04");

            migrationBuilder.DropColumn(
                name: "progress_percentage",
                table: "questionnaire_motorskill06");

            migrationBuilder.DropColumn(
                name: "progress_percentage",
                table: "questionnaire_motor05");

            migrationBuilder.DropColumn(
                name: "progress_percentage",
                table: "questionnaire_moca07");

            migrationBuilder.DropColumn(
                name: "progress_percentage",
                table: "questionnaire_general01");

            migrationBuilder.DropColumn(
                name: "progress_percentage",
                table: "questionnaire_exclusion08");

            migrationBuilder.DropColumn(
                name: "entry_progress_percentage",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "ongoing_progress_percentage",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "result_progress_percentage",
                table: "patients");
        }
    }
}
