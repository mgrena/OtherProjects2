using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Servier.Pressure.Migrations
{
    /// <inheritdoc />
    public partial class DataUpdate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "list_treatment_multitherapy_drugs",
                keyColumn: "id",
                keyValue: 8,
                column: "drug",
                value: "lisinopril / amlodipín");

            migrationBuilder.UpdateData(
                table: "list_treatment_multitherapy_drugs",
                keyColumn: "id",
                keyValue: 10,
                column: "drug",
                value: "losartan / amlodipín");

            migrationBuilder.UpdateData(
                table: "list_treatment_multitherapy_drugs",
                keyColumn: "id",
                keyValue: 20,
                column: "drug",
                value: "telmisartan / HCTZ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "list_treatment_multitherapy_drugs",
                keyColumn: "id",
                keyValue: 8,
                column: "drug",
                value: "lisinopril / amlodipine");

            migrationBuilder.UpdateData(
                table: "list_treatment_multitherapy_drugs",
                keyColumn: "id",
                keyValue: 10,
                column: "drug",
                value: "losartan/ amlodipín");

            migrationBuilder.UpdateData(
                table: "list_treatment_multitherapy_drugs",
                keyColumn: "id",
                keyValue: 20,
                column: "drug",
                value: "telmisartan/ HCTZ");
        }
    }
}
