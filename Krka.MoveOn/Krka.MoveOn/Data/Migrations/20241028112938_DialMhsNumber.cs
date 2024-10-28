using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Krka.MoveOn.Migrations
{
    /// <inheritdoc />
    public partial class DialMhsNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "dial_mhs",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "dial_mhs",
                keyColumn: "id",
                keyValue: 1,
                column: "Number",
                value: "1");

            migrationBuilder.UpdateData(
                table: "dial_mhs",
                keyColumn: "id",
                keyValue: 2,
                column: "Number",
                value: "1,5");

            migrationBuilder.UpdateData(
                table: "dial_mhs",
                keyColumn: "id",
                keyValue: 3,
                column: "Number",
                value: "2");

            migrationBuilder.UpdateData(
                table: "dial_mhs",
                keyColumn: "id",
                keyValue: 4,
                column: "Number",
                value: "2,5");

            migrationBuilder.UpdateData(
                table: "dial_mhs",
                keyColumn: "id",
                keyValue: 5,
                column: "Number",
                value: "3");

            migrationBuilder.UpdateData(
                table: "dial_mhs",
                keyColumn: "id",
                keyValue: 6,
                column: "Number",
                value: "4");

            migrationBuilder.UpdateData(
                table: "dial_mhs",
                keyColumn: "id",
                keyValue: 7,
                column: "Number",
                value: "5");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                table: "dial_mhs");
        }
    }
}
