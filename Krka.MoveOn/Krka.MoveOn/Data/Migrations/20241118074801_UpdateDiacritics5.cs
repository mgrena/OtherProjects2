using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Krka.MoveOn.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDiacritics5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 14,
                column: "Name",
                value: "Smrť");

            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 18,
                column: "Name",
                value: "Ťažká (Spôsobuje neschopnosť vykonávať bežné činnosti, pacient môže pociťovať neznesiteľné nepohodlie alebo bolesť)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 14,
                column: "Name",
                value: "Smrť");

            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 18,
                column: "Name",
                value: "Ťažká (Spôsobuje neschopnosť vykonávať bežné činnosti, pacient môže pociťovať neznesiteľné nepohodlie alebo bolesť)");
        }
    }
}
