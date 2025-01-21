using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Krka.MoveOn.Migrations
{
    /// <inheritdoc />
    public partial class PatientCodeUniqueDel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_patients_patient_code",
                table: "patients");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_patients_patient_code",
                table: "patients",
                column: "patient_code",
                unique: true);
        }
    }
}
