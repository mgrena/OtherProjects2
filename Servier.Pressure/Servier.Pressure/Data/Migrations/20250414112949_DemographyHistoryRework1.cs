using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Servier.Pressure.Migrations
{
    /// <inheritdoc />
    public partial class DemographyHistoryRework1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "diag_ICHS_angiography_type",
                table: "demographies");

            migrationBuilder.DropColumn(
                name: "diag_ICHS_revascularization_type",
                table: "demographies");

            migrationBuilder.AddColumn<bool>(
                name: "diag_ICHS_angiography_angiography",
                table: "demographies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "diag_ICHS_angiography_ct",
                table: "demographies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "diag_ICHS_revascularization_cabg",
                table: "demographies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "diag_ICHS_revascularization_pci",
                table: "demographies",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "diag_ICHS_angiography_angiography",
                table: "demographies");

            migrationBuilder.DropColumn(
                name: "diag_ICHS_angiography_ct",
                table: "demographies");

            migrationBuilder.DropColumn(
                name: "diag_ICHS_revascularization_cabg",
                table: "demographies");

            migrationBuilder.DropColumn(
                name: "diag_ICHS_revascularization_pci",
                table: "demographies");

            migrationBuilder.AddColumn<int>(
                name: "diag_ICHS_angiography_type",
                table: "demographies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "diag_ICHS_revascularization_type",
                table: "demographies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
