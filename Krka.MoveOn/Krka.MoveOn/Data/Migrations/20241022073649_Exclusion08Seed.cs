using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Krka.MoveOn.Migrations
{
    /// <inheritdoc />
    public partial class Exclusion08Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "exc_2",
                table: "questionnaire_exclusion08",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "exc_1",
                table: "questionnaire_exclusion08",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "dial_exlusions",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "dial_exlusions",
                columns: new[] { "id", "created_at", "modified_at", "Name", "type_q" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pri návšteve pacienta na mieste", 1 },
                    { 2, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Na diaľku prostredníctvom telefonického hovoru", 1 },
                    { 3, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Na diaľku prostredníctvom elektronických médií", 1 },
                    { 4, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Výskyt závažnej nežiaducej reakcie počas pozorovacieho obdobia v tejto štúdii", 2 },
                    { 5, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Smrť", 2 },
                    { 6, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hospitalizácia", 2 },
                    { 7, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rozhodnutie pacienta ukončiť liečbu a odvolanie jeho informovaného súhlasu", 2 },
                    { 8, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rozhodnutie pacienta ukončiť liečbu a odvolanie informovaného súhlasu a GDPR formulára", 2 },
                    { 9, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bezpečnosť pacienta (napr. rozhodnutie skúšajúceho vylúčiť pacienta zo štúdie v jeho najlepšom záujme, nežiaduce účinky vyžadujúce medikamentózny zásah alebo ukončenie liečby)", 2 },
                    { 10, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "O alebo zhoršenie existujúceho ochorenia počas štúdie, ktoré si vyžaduje používanie liekov, ktoré nie sú povolené v spojení so súhrnom charakteristických vlastností lieku použitých liekov", 2 },
                    { 11, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iné...", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.AlterColumn<int>(
                name: "exc_2",
                table: "questionnaire_exclusion08",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "exc_1",
                table: "questionnaire_exclusion08",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "dial_exlusions",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);
        }
    }
}
