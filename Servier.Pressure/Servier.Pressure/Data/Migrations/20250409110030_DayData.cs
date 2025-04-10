using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Servier.Pressure.Migrations
{
    /// <inheritdoc />
    public partial class DayData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "blood_pressure_monitors",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    is_omron_monitor = table.Column<bool>(type: "bit", nullable: false),
                    omron_number = table.Column<int>(type: "int", nullable: false),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blood_pressure_monitors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "day_records",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    day_num = table.Column<int>(type: "int", nullable: false),
                    measurement_1_pressure = table.Column<bool>(type: "bit", nullable: false),
                    measurement_1_pulse = table.Column<bool>(type: "bit", nullable: false),
                    measurement_1_stk = table.Column<int>(type: "int", nullable: true),
                    measurement_1_dtk = table.Column<int>(type: "int", nullable: true),
                    measurement_1_sf = table.Column<int>(type: "int", nullable: true),
                    measurement_2_pressure = table.Column<bool>(type: "bit", nullable: false),
                    measurement_2_pulse = table.Column<bool>(type: "bit", nullable: false),
                    measurement_2_stk = table.Column<int>(type: "int", nullable: true),
                    measurement_2_dtk = table.Column<int>(type: "int", nullable: true),
                    measurement_2_sf = table.Column<int>(type: "int", nullable: true),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_day_records", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "blood_pressure_monitors");

            migrationBuilder.DropTable(
                name: "day_records");
        }
    }
}
