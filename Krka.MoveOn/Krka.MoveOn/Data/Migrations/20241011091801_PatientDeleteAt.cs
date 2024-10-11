using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Krka.MoveOn.Migrations
{
    /// <inheritdoc />
    public partial class PatientDeleteAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "deleted_at",
                table: "patients",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 12,
                column: "Name",
                value: "Poruchy močenia");

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 18,
                column: "Name",
                value: "Úzkosť");

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 20,
                column: "Name",
                value: "Iné- uviesť");

            migrationBuilder.UpdateData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 12,
                column: "Name",
                value: "Ex-fajčiar");

            migrationBuilder.UpdateData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 36,
                column: "Name",
                value: "Porucha čuchu");

            migrationBuilder.UpdateData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 38,
                column: "Name",
                value: "Depresia alebo úzkosť");

            migrationBuilder.UpdateData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 56,
                column: "Name",
                value: "Nič z vyššie uvedeného ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "deleted_at",
                table: "patients");

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 12,
                column: "Name",
                value: "Poruchy moèenia");

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 18,
                column: "Name",
                value: "Úzkos");

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 20,
                column: "Name",
                value: "Iné- uvies");

            migrationBuilder.UpdateData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 12,
                column: "Name",
                value: "Ex-fajèiar");

            migrationBuilder.UpdateData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 36,
                column: "Name",
                value: "Porucha èuchu");

            migrationBuilder.UpdateData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 38,
                column: "Name",
                value: "Depresia alebo úzkos");

            migrationBuilder.UpdateData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 56,
                column: "Name",
                value: "Niè z vyššie uvedeného ");
        }
    }
}
