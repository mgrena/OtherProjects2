using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Krka.MoveOn.Migrations
{
    /// <inheritdoc />
    public partial class Treatment03OtherIndic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "other",
                table: "questionnaire_treatment03",
                newName: "other_treat");

            migrationBuilder.AddColumn<string>(
                name: "other_indication",
                table: "questionnaire_treatment03",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "other_indication",
                table: "questionnaire_treatment03");

            migrationBuilder.RenameColumn(
                name: "other_treat",
                table: "questionnaire_treatment03",
                newName: "other");
        }
    }
}
