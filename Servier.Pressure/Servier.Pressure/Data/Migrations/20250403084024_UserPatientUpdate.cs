using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Servier.Pressure.Migrations
{
    /// <inheritdoc />
    public partial class UserPatientUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "patient",
                table: "patients",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "code",
                table: "AspNetUsers",
                type: "char(3)",
                maxLength: 3,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "list_treatment_multitherapy_drugs",
                keyColumn: "id",
                keyValue: 29,
                column: "drug",
                value: "rosuvastatín / perindopril / indapamid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "patient",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "code",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "list_treatment_multitherapy_drugs",
                keyColumn: "id",
                keyValue: 29,
                column: "drug",
                value: "rosuvastatín / perindopril / HCTZ");
        }
    }
}
