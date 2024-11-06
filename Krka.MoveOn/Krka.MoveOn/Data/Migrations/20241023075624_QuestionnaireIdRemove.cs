using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Krka.MoveOn.Migrations
{
    /// <inheritdoc />
    public partial class QuestionnaireIdRemove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_questionnaires",
                table: "questionnaires");

            migrationBuilder.DropColumn(
                name: "id",
                table: "questionnaires");

            migrationBuilder.AddPrimaryKey(
                name: "PK_questionnaires",
                table: "questionnaires",
                column: "id_new");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_questionnaires",
                table: "questionnaires");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "questionnaires",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_questionnaires",
                table: "questionnaires",
                column: "id");
        }
    }
}
