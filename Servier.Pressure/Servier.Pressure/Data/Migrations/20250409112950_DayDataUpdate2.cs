using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Servier.Pressure.Migrations
{
    /// <inheritdoc />
    public partial class DayDataUpdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_day_records",
                table: "day_records");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "day_records",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_day_records",
                table: "day_records",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_day_records",
                table: "day_records");

            migrationBuilder.DropColumn(
                name: "id",
                table: "day_records");

            migrationBuilder.AddPrimaryKey(
                name: "PK_day_records",
                table: "day_records",
                column: "id_patient");
        }
    }
}
