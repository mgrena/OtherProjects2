using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Krka.MoveOn.Migrations
{
    /// <inheritdoc />
    public partial class DialGeneralQ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "dial_q_general",
                columns: new[] { "id", "created_at", "modified_at", "Name", "type_q" },
                values: new object[,]
                {
                    { 3, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Slobodný/á", 2 },
                    { 4, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ženatý/Vydatá", 2 },
                    { 5, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vdovec/Vdova", 2 },
                    { 6, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rozvedený/á", 2 },
                    { 7, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zamestnaný/á", 3 },
                    { 8, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nezamestnaný/á", 3 },
                    { 9, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Starobný dôchodok", 3 },
                    { 10, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Invalidný dôchodok", 3 },
                    { 11, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Áno", 4 },
                    { 12, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ex-fajčiar", 4 },
                    { 13, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nie", 4 },
                    { 14, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Áno", 5 },
                    { 15, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nie", 5 },
                    { 16, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Áno", 6 },
                    { 17, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nie", 6 },
                    { 18, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kvetiapín", 7 },
                    { 19, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Klozapín", 7 },
                    { 20, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Olanzapín", 7 },
                    { 21, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Risperidon", 7 },
                    { 22, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paliperidon", 7 },
                    { 23, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tiapridal", 7 },
                    { 24, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Haloperidol", 7 },
                    { 25, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chloprprotixen", 7 },
                    { 26, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lurasidon", 7 },
                    { 27, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aripiprazol", 7 },
                    { 28, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Levomepromazin", 7 },
                    { 29, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Flupentixol", 7 },
                    { 30, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zuklopentixol", 7 },
                    { 31, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sulpirid", 7 },
                    { 32, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amilsulprid", 7 },
                    { 33, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziprasidon", 7 },
                    { 34, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iné...", 7 },
                    { 35, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "mg", 8 },
                    { 36, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Porucha čuchu", 9 },
                    { 37, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Porucha správania v REM spánku", 9 },
                    { 38, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Depresia alebo úzkosť", 9 },
                    { 39, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dlhotrvajúca zápcha", 9 },
                    { 40, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bolesti ramena", 9 },
                    { 41, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Predklonený postoj", 9 },
                    { 42, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spomalené pohyby/chôdza", 9 },
                    { 43, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tras", 9 },
                    { 44, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oslabená mimika v tvári (hypomímia)", 9 },
                    { 45, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vytekanie slín z úst", 9 },
                    { 46, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Problémy s ranným vstávaním z postele", 9 },
                    { 47, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Opakované pády", 9 },
                    { 48, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Praktický lekár", 10 },
                    { 49, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ortopéd", 10 },
                    { 50, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Neurológ", 10 },
                    { 51, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Psychiater", 10 },
                    { 52, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fyzioterapeut", 10 },
                    { 53, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Internista", 10 },
                    { 54, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Idiopatická PCH", 11 },
                    { 55, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iný parkinsonský syndróm ", 11 },
                    { 56, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nič z vyššie uvedeného ", 11 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 56);
        }
    }
}
