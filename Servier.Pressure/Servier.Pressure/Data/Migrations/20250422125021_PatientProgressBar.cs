using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Servier.Pressure.Migrations
{
    /// <inheritdoc />
    public partial class PatientProgressBar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "filling_01_info",
                table: "patients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "filling_02_before",
                table: "patients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "filling_03_demogr",
                table: "patients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "filling_04_visit1",
                table: "patients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "filling_05_visit2",
                table: "patients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "filling_06_measure",
                table: "patients",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "filling_01_info",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "filling_02_before",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "filling_03_demogr",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "filling_04_visit1",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "filling_05_visit2",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "filling_06_measure",
                table: "patients");
        }
    }
}
