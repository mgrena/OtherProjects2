using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Servier.Pressure.Migrations
{
    /// <inheritdoc />
    public partial class InformedConsentCompetence : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "info",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    is_consent = table.Column<bool>(type: "bit", nullable: false),
                    is_adult = table.Column<bool>(type: "bit", nullable: false),
                    is_stable_hypertension = table.Column<bool>(type: "bit", nullable: false),
                    is_informed_consent = table.Column<bool>(type: "bit", nullable: false),
                    is_already_enrolled = table.Column<bool>(type: "bit", nullable: false),
                    is_resistant_hypertension = table.Column<bool>(type: "bit", nullable: false),
                    is_clinical_trial = table.Column<bool>(type: "bit", nullable: false),
                    is_pregnant = table.Column<bool>(type: "bit", nullable: false),
                    visit_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_info", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "info");
        }
    }
}
