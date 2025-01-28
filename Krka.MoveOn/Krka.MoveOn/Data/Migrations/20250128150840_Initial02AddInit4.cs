using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Krka.MoveOn.Migrations
{
    /// <inheritdoc />
    public partial class Initial02AddInit4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "init_4",
                table: "questionnaire_initial02",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "dial_q_general",
                columns: new[] { "id", "created_at", "modified_at", "Name", "type_q" },
                values: new object[,]
                {
                    { 58, new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gastroenterológ", 10 },
                    { 59, new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Urológ", 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DropColumn(
                name: "init_4",
                table: "questionnaire_initial02");
        }
    }
}
