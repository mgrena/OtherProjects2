using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Servier.Pressure.Migrations
{
    /// <inheritdoc />
    public partial class Treatment1VisitUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "is_issuing_recorder",
                table: "treatments_1_visit",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "is_ongoing",
                table: "treatments_1_visit",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "is_pressure_gauge",
                table: "treatments_1_visit",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_issuing_recorder",
                table: "treatments_1_visit");

            migrationBuilder.DropColumn(
                name: "is_ongoing",
                table: "treatments_1_visit");

            migrationBuilder.DropColumn(
                name: "is_pressure_gauge",
                table: "treatments_1_visit");
        }
    }
}
