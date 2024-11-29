using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Krka.MoveOn.Migrations
{
    /// <inheritdoc />
    public partial class GenQuestionnareUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "gen_7_1_1",
                table: "questionnaire_general01");

            migrationBuilder.DropColumn(
                name: "gen_7_1_2",
                table: "questionnaire_general01");

            migrationBuilder.DropColumn(
                name: "gen_7_1_3_du",
                table: "questionnaire_general01");

            migrationBuilder.DropColumn(
                name: "gen_7_1_4",
                table: "questionnaire_general01");

            migrationBuilder.DropColumn(
                name: "gen_7_1_dm",
                table: "questionnaire_general01");

            migrationBuilder.DropColumn(
                name: "gen_7_2",
                table: "questionnaire_general01");

            migrationBuilder.DropColumn(
                name: "gen_7_3_du",
                table: "questionnaire_general01");

            migrationBuilder.DropColumn(
                name: "gen_7_4",
                table: "questionnaire_general01");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "gen_7_1_1",
                table: "questionnaire_general01",
                type: "varchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "gen_7_1_2",
                table: "questionnaire_general01",
                type: "decimal(5,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "gen_7_1_3_du",
                table: "questionnaire_general01",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "gen_7_1_4",
                table: "questionnaire_general01",
                type: "decimal(3,1)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "gen_7_1_dm",
                table: "questionnaire_general01",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "gen_7_2",
                table: "questionnaire_general01",
                type: "decimal(5,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "gen_7_3_du",
                table: "questionnaire_general01",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "gen_7_4",
                table: "questionnaire_general01",
                type: "decimal(3,1)",
                nullable: true);
        }
    }
}
