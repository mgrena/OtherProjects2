using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Krka.MoveOn.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDiacritics4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "dial_mhs",
                keyColumn: "id",
                keyValue: 6,
                column: "Name",
                value: "Ťažké postihnutie, no pacient je schopný chodiť alebo stáť bez pomoci");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "dial_mhs",
                keyColumn: "id",
                keyValue: 6,
                column: "Name",
                value: "Ťažké postihnutie, no pacient je schopný chodiť alebo stáť bez pomoci");
        }
    }
}
