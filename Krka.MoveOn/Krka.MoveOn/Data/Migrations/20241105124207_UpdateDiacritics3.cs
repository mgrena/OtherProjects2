using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Krka.MoveOn.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDiacritics3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "dial_indications",
                keyColumn: "id",
                keyValue: 1,
                column: "Name",
                value: "Poruchy močenia");

            migrationBuilder.UpdateData(
                table: "dial_indications",
                keyColumn: "id",
                keyValue: 7,
                column: "Name",
                value: "Úzkosť");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "dial_indications",
                keyColumn: "id",
                keyValue: 1,
                column: "Name",
                value: "Pruhy močenia");

            migrationBuilder.UpdateData(
                table: "dial_indications",
                keyColumn: "id",
                keyValue: 7,
                column: "Name",
                value: "Úzkosť");
        }
    }
}
