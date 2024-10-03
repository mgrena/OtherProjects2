using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Krka.MoveOn.Migrations
{
    /// <inheritdoc />
    public partial class AdverseEffects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "adverse_effects",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_questionnaire = table.Column<int>(type: "int", nullable: false),
                    adverse_effect = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    start = table.Column<int>(type: "int", nullable: false),
                    frequency = table.Column<int>(type: "int", nullable: false),
                    related = table.Column<int>(type: "int", nullable: false),
                    severity = table.Column<int>(type: "int", nullable: false),
                    intensity = table.Column<int>(type: "int", nullable: false),
                    effect = table.Column<int>(type: "int", nullable: false),
                    result = table.Column<int>(type: "int", nullable: false),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adverse_effects", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "adverse_effects");
        }
    }
}
