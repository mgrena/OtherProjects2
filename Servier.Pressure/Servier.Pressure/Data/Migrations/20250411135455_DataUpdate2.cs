using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Servier.Pressure.Migrations
{
    /// <inheritdoc />
    public partial class DataUpdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 19,
                column: "drug",
                value: "lerkanidipín");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 19,
                column: "drug",
                value: "lercandipín");
        }
    }
}
