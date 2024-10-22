using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Krka.MoveOn.Migrations
{
    /// <inheritdoc />
    public partial class AdverseEffectSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "dial_adverse_effects",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "start",
                table: "adverse_effects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "severity",
                table: "adverse_effects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "result",
                table: "adverse_effects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "related",
                table: "adverse_effects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "intensity",
                table: "adverse_effects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "frequency",
                table: "adverse_effects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "effect",
                table: "adverse_effects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "adverse_effect",
                table: "adverse_effects",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "dial_adverse_effects",
                columns: new[] { "id", "created_at", "modified_at", "Name", "type_q" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jedenkrát", 1 },
                    { 2, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Občas", 1 },
                    { 3, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Neustále", 1 },
                    { 4, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nesúvisí (Ak je NU klasifikovaná ako nesúvisiaca s liekom)", 2 },
                    { 5, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nepravdepodobne súvisí (udalosť s najväčšou pravdepodobnosťou nebola spôsobená liekom, ale príčinnú súvislosť nemožno úplne vylúčiť)", 2 },
                    { 6, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Možno súvisí (Udalosť môže, ale nemusí byť spôsobená liekom, príčinnú súvislosť nie je možné posúdiť s väčšou istotou)", 2 },
                    { 7, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pravdepodobne súvisí (Liek je najpravdepodobnejšou príčinou udalosti, ale nemožno vylúčiť iné príčiny)", 2 },
                    { 8, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Takmer určite súvisí (Liek je takmer určite príčinou udalosti, neexistujú žiadne iné zjavné alternatívne vysvetlenia)", 2 },
                    { 9, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nezávažné", 3 },
                    { 10, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Život ohrozujúce", 3 },
                    { 11, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hospitalizácia (začatá alebo predĺžená)", 3 },
                    { 12, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zdravotné postihnutie", 3 },
                    { 13, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vrodená anomália", 3 },
                    { 14, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Smrť", 3 },
                    { 15, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Závažné podľa názoru skúšajúceho lekára", 3 },
                    { 16, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mierna (Nespôsobuje obmedzenie bežných činností, pacient môže pociťovať mierne nepohodlie)", 4 },
                    { 17, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stredne ťažká (Spôsobuje určité obmedzenia bežných aktivít, pacient môže pociťovať nepríjemné nepohodlie)", 4 },
                    { 18, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ťažká (Spôsobuje neschopnosť vykonávať bežné činnosti, pacient môže pociťovať neznesiteľné nepohodlie alebo bolesť)", 4 },
                    { 19, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bez následkov", 5 },
                    { 20, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zmeny v liečbe", 5 },
                    { 21, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zníženie dávky", 5 },
                    { 22, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Symptomatická liečba", 5 },
                    { 23, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hospitalizácia", 5 },
                    { 24, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prestala", 6 },
                    { 25, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokračuje", 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "dial_adverse_effects",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<int>(
                name: "start",
                table: "adverse_effects",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "severity",
                table: "adverse_effects",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "result",
                table: "adverse_effects",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "related",
                table: "adverse_effects",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "intensity",
                table: "adverse_effects",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "frequency",
                table: "adverse_effects",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "effect",
                table: "adverse_effects",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "adverse_effect",
                table: "adverse_effects",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);
        }
    }
}
