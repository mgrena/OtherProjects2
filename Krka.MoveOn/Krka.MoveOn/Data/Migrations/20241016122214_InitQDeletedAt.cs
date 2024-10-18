using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Krka.MoveOn.Migrations
{
    /// <inheritdoc />
    public partial class InitQDeletedAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.AddColumn<DateTime>(
                name: "deleted_at",
                table: "questionnaire_initial02",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 1,
                column: "Name",
                value: "Levodopa/Karbidopa");

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 2,
                column: "Name",
                value: "Levodopa/Benserazid");

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 3,
                column: "Name",
                value: "Entakapon");

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 4,
                column: "Name",
                value: "Tolkapon");

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 5,
                column: "Name",
                value: "Opikapon");

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 6,
                column: "Name",
                value: "Rasagilín");

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 7,
                column: "Name",
                value: "Pramipexol");

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 8,
                column: "Name",
                value: "Ropinirol");

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 9,
                column: "Name",
                value: "Rotigotín");

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 10,
                column: "Name",
                value: "Apomorfín");

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 11,
                column: "Name",
                value: "Amantadín");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "deleted_at",
                table: "questionnaire_initial02");

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 1,
                column: "Name",
                value: "levodopa/karbidopa");

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 2,
                column: "Name",
                value: "levodopa/benserazid");

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 3,
                column: "Name",
                value: "entakapon");

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 4,
                column: "Name",
                value: "tolkapon");

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 5,
                column: "Name",
                value: "opikapon");

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 6,
                column: "Name",
                value: "rasagilín");

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 7,
                column: "Name",
                value: "pramipexol");

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 8,
                column: "Name",
                value: "ropinirol");

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 9,
                column: "Name",
                value: "rotigotín");

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 10,
                column: "Name",
                value: "apomorfín");

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 11,
                column: "Name",
                value: "amantadín");

            migrationBuilder.InsertData(
                table: "dial_active_ingredient",
                columns: new[] { "id", "created_at", "modified_at", "Name", "type_q" },
                values: new object[,]
                {
                    { 12, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Poruchy močenia", 2 },
                    { 13, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Erektilná dysfunkcia", 2 },
                    { 14, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zápcha", 2 },
                    { 15, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Porucha spánku", 2 },
                    { 16, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ortostatická hypotenzia", 2 },
                    { 17, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Depresia", 2 },
                    { 18, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Úzkosť", 2 },
                    { 19, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Psychóza (halucinácie, bludy)", 2 },
                    { 20, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iné- uviesť", 2 }
                });
        }
    }
}
