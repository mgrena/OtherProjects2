using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Servier.Pressure.Migrations
{
    /// <inheritdoc />
    public partial class LaboratoryTestUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "non_hdl",
                table: "laboratory_tests");

            migrationBuilder.DropColumn(
                name: "non_hdl_unknown",
                table: "laboratory_tests");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "non_hdl",
                table: "laboratory_tests",
                type: "decimal(4,1)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "non_hdl_unknown",
                table: "laboratory_tests",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
