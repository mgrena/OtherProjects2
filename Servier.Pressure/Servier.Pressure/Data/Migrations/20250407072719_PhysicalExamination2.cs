using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Servier.Pressure.Migrations
{
    /// <inheritdoc />
    public partial class PhysicalExamination2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "physical_examinations_2",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    ambulatory_monitor = table.Column<bool>(type: "bit", nullable: false),
                    borrowed_monitor = table.Column<bool>(type: "bit", nullable: false),
                    a_hand = table.Column<int>(type: "int", nullable: false),
                    a_measurement_1 = table.Column<bool>(type: "bit", nullable: false),
                    a_measurement_1_stk = table.Column<int>(type: "int", nullable: false),
                    a_measurement_1_dtk = table.Column<int>(type: "int", nullable: false),
                    a_measurement_1_sf = table.Column<int>(type: "int", nullable: false),
                    a_measurement_2 = table.Column<bool>(type: "bit", nullable: false),
                    a_measurement_2_stk = table.Column<int>(type: "int", nullable: false),
                    a_measurement_2_dtk = table.Column<int>(type: "int", nullable: false),
                    a_measurement_2_sf = table.Column<int>(type: "int", nullable: false),
                    a_measurement_3 = table.Column<bool>(type: "bit", nullable: false),
                    a_measurement_3_stk = table.Column<int>(type: "int", nullable: false),
                    a_measurement_3_dtk = table.Column<int>(type: "int", nullable: false),
                    a_measurement_3_sf = table.Column<int>(type: "int", nullable: false),
                    b_hand = table.Column<int>(type: "int", nullable: false),
                    b_measurement_1 = table.Column<bool>(type: "bit", nullable: false),
                    b_measurement_1_stk = table.Column<int>(type: "int", nullable: false),
                    b_measurement_1_dtk = table.Column<int>(type: "int", nullable: false),
                    b_measurement_1_sf = table.Column<int>(type: "int", nullable: false),
                    b_measurement_2 = table.Column<bool>(type: "bit", nullable: false),
                    b_measurement_2_stk = table.Column<int>(type: "int", nullable: false),
                    b_measurement_2_dtk = table.Column<int>(type: "int", nullable: false),
                    b_measurement_2_sf = table.Column<int>(type: "int", nullable: false),
                    b_measurement_3 = table.Column<bool>(type: "bit", nullable: false),
                    b_measurement_3_stk = table.Column<int>(type: "int", nullable: false),
                    b_measurement_3_dtk = table.Column<int>(type: "int", nullable: false),
                    b_measurement_3_sf = table.Column<int>(type: "int", nullable: false),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_physical_examinations_2", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "physical_examinations_2");
        }
    }
}
