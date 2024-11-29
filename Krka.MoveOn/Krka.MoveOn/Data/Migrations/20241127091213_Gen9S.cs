using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Krka.MoveOn.Migrations
{
    /// <inheritdoc />
    public partial class Gen9S : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "gen_9_ds",
                table: "questionnaire_general01");

            migrationBuilder.RenameColumn(
                name: "Gen9DS_Id",
                table: "rel_Gen9DS",
                newName: "GenQuestId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GenQuestId",
                table: "rel_Gen9DS",
                newName: "Gen9DS_Id");

            migrationBuilder.AddColumn<int>(
                name: "gen_9_ds",
                table: "questionnaire_general01",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
