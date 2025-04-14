using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Servier.Pressure.Migrations
{
    /// <inheritdoc />
    public partial class DayRecordRework : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "measurement_2_stk",
                table: "day_records",
                newName: "morning_2_stk");

            migrationBuilder.RenameColumn(
                name: "measurement_2_sf",
                table: "day_records",
                newName: "morning_2_sf");

            migrationBuilder.RenameColumn(
                name: "measurement_2_pulse",
                table: "day_records",
                newName: "morning_2_pulse");

            migrationBuilder.RenameColumn(
                name: "measurement_2_pressure",
                table: "day_records",
                newName: "morning_2_pressure");

            migrationBuilder.RenameColumn(
                name: "measurement_2_dtk",
                table: "day_records",
                newName: "morning_2_dtk");

            migrationBuilder.RenameColumn(
                name: "measurement_1_stk",
                table: "day_records",
                newName: "morning_1_stk");

            migrationBuilder.RenameColumn(
                name: "measurement_1_sf",
                table: "day_records",
                newName: "morning_1_sf");

            migrationBuilder.RenameColumn(
                name: "measurement_1_pulse",
                table: "day_records",
                newName: "morning_1_pulse");

            migrationBuilder.RenameColumn(
                name: "measurement_1_pressure",
                table: "day_records",
                newName: "morning_1_pressure");

            migrationBuilder.RenameColumn(
                name: "measurement_1_dtk",
                table: "day_records",
                newName: "morning_1_dtk");

            migrationBuilder.AddColumn<int>(
                name: "evening_1_dtk",
                table: "day_records",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "evening_1_pressure",
                table: "day_records",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "evening_1_pulse",
                table: "day_records",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "evening_1_sf",
                table: "day_records",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "evening_1_stk",
                table: "day_records",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "evening_2_dtk",
                table: "day_records",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "evening_2_pressure",
                table: "day_records",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "evening_2_pulse",
                table: "day_records",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "evening_2_sf",
                table: "day_records",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "evening_2_stk",
                table: "day_records",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "evening_1_dtk",
                table: "day_records");

            migrationBuilder.DropColumn(
                name: "evening_1_pressure",
                table: "day_records");

            migrationBuilder.DropColumn(
                name: "evening_1_pulse",
                table: "day_records");

            migrationBuilder.DropColumn(
                name: "evening_1_sf",
                table: "day_records");

            migrationBuilder.DropColumn(
                name: "evening_1_stk",
                table: "day_records");

            migrationBuilder.DropColumn(
                name: "evening_2_dtk",
                table: "day_records");

            migrationBuilder.DropColumn(
                name: "evening_2_pressure",
                table: "day_records");

            migrationBuilder.DropColumn(
                name: "evening_2_pulse",
                table: "day_records");

            migrationBuilder.DropColumn(
                name: "evening_2_sf",
                table: "day_records");

            migrationBuilder.DropColumn(
                name: "evening_2_stk",
                table: "day_records");

            migrationBuilder.RenameColumn(
                name: "morning_2_stk",
                table: "day_records",
                newName: "measurement_2_stk");

            migrationBuilder.RenameColumn(
                name: "morning_2_sf",
                table: "day_records",
                newName: "measurement_2_sf");

            migrationBuilder.RenameColumn(
                name: "morning_2_pulse",
                table: "day_records",
                newName: "measurement_2_pulse");

            migrationBuilder.RenameColumn(
                name: "morning_2_pressure",
                table: "day_records",
                newName: "measurement_2_pressure");

            migrationBuilder.RenameColumn(
                name: "morning_2_dtk",
                table: "day_records",
                newName: "measurement_2_dtk");

            migrationBuilder.RenameColumn(
                name: "morning_1_stk",
                table: "day_records",
                newName: "measurement_1_stk");

            migrationBuilder.RenameColumn(
                name: "morning_1_sf",
                table: "day_records",
                newName: "measurement_1_sf");

            migrationBuilder.RenameColumn(
                name: "morning_1_pulse",
                table: "day_records",
                newName: "measurement_1_pulse");

            migrationBuilder.RenameColumn(
                name: "morning_1_pressure",
                table: "day_records",
                newName: "measurement_1_pressure");

            migrationBuilder.RenameColumn(
                name: "morning_1_dtk",
                table: "day_records",
                newName: "measurement_1_dtk");
        }
    }
}
