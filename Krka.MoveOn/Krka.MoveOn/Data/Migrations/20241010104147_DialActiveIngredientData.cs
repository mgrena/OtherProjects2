using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Krka.MoveOn.Migrations
{
    /// <inheritdoc />
    public partial class DialActiveIngredientData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "dial_active_ingredient",
                columns: new[] { "id", "created_at", "modified_at", "Name", "type_q" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "levodopa/karbidopa", 1 },
                    { 2, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "levodopa/benserazid", 1 },
                    { 3, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "entakapon", 1 },
                    { 4, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "tolkapon", 1 },
                    { 5, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "opikapon", 1 },
                    { 6, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "rasagilín", 1 },
                    { 7, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "pramipexol", 1 },
                    { 8, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ropinirol", 1 },
                    { 9, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "rotigotín", 1 },
                    { 10, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "apomorfín", 1 },
                    { 11, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "amantadín", 1 },
                    { 12, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Poruchy moèenia", 2 },
                    { 13, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Erektilná dysfunkcia", 2 },
                    { 14, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zápcha", 2 },
                    { 15, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Porucha spánku", 2 },
                    { 16, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ortostatická hypotenzia", 2 },
                    { 17, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Depresia", 2 },
                    { 18, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Úzkos", 2 },
                    { 19, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Psychóza (halucinácie, bludy)", 2 },
                    { 20, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iné- uvies", 2 }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 11);

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
    }
}
