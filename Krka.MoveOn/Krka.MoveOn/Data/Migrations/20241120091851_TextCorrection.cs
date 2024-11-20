using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Krka.MoveOn.Migrations
{
    /// <inheritdoc />
    public partial class TextCorrection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 25,
                column: "Name",
                value: "Chlorprotixen");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 25,
                column: "Name",
                value: "Chloprprotixen");
        }
    }
}
