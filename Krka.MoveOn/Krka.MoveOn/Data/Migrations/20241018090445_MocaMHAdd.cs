using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Krka.MoveOn.Migrations
{
    /// <inheritdoc />
    public partial class MocaMHAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "mh_1",
                table: "questionnaire_motorskill06");

            migrationBuilder.AddColumn<int>(
                name: "mh_1",
                table: "questionnaire_moca07",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "dial_mhs",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "dial_mhs",
                columns: new[] { "id", "created_at", "modified_at", "Name", "type_q" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jednostranné príznaky", 1 },
                    { 2, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jednostranné a axiálne príznaky (hypofónia, hypomímia, flekčnédržanie tela)", 1 },
                    { 3, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Obojstranné príznaky bez poruchy rovnováhy", 1 },
                    { 4, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Obojstranné príznaky s miernou poruchou rovnováhy (schopnosť vyrovnať postoj pri pull teste)", 1 },
                    { 5, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mierne až stredné obojstranné príznaky, posturálnainstabilita, pacient je stále sebestačný", 1 },
                    { 6, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ťažké postihnutie, no pacient je schopný chodiť alebo stáť bez pomoci", 1 },
                    { 7, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pacient je odkázaný na vozík alebo posteľ", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "dial_mhs",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "dial_mhs",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "dial_mhs",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "dial_mhs",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "dial_mhs",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "dial_mhs",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "dial_mhs",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "mh_1",
                table: "questionnaire_moca07");

            migrationBuilder.AddColumn<int>(
                name: "mh_1",
                table: "questionnaire_motorskill06",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "dial_mhs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);
        }
    }
}
