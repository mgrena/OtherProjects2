using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Krka.MoveOn.Migrations
{
    /// <inheritdoc />
    public partial class Treat03DeletedAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "deleted_at",
                table: "questionnaire_treatment03",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "dial_indications",
                columns: new[] { "id", "created_at", "modified_at", "Name", "type_q" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pruhy močenia", 1 },
                    { 2, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Erektilná dysfunkcia", 1 },
                    { 3, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zápcha", 1 },
                    { 4, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Porucha spánku", 1 },
                    { 5, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ortostatická hypotenzia", 1 },
                    { 6, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Depresia", 1 },
                    { 7, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Úzkosť", 1 },
                    { 8, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Psychóza (halucinácie, bludy)", 1 },
                    { 9, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iné...", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "dial_indications",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "dial_indications",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "dial_indications",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "dial_indications",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "dial_indications",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "dial_indications",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "dial_indications",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "dial_indications",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "dial_indications",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DropColumn(
                name: "deleted_at",
                table: "questionnaire_treatment03");
        }
    }
}
