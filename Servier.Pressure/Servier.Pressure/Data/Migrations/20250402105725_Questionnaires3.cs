using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Servier.Pressure.Migrations
{
    /// <inheritdoc />
    public partial class Questionnaires3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "treatments_1_visit",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    is_changed = table.Column<bool>(type: "bit", nullable: false),
                    fix_combination_3_unknown = table.Column<bool>(type: "bit", nullable: false),
                    fix_combination_mix_unknown = table.Column<bool>(type: "bit", nullable: false),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_treatments_1_visit", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "treatments_2_visit",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    is_changed = table.Column<bool>(type: "bit", nullable: false),
                    fix_combination_3_unknown = table.Column<bool>(type: "bit", nullable: false),
                    fix_combination_mix_unknown = table.Column<bool>(type: "bit", nullable: false),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_treatments_2_visit", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "treatments_1_visit");

            migrationBuilder.DropTable(
                name: "treatments_2_visit");
        }
    }
}
