using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Krka.MoveOn.Migrations
{
    /// <inheritdoc />
    public partial class De4OnString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "de_4",
                table: "questionnaire_drug_effect09",
                type: "varchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 5,
                column: "Name",
                value: "Smrť *");

            migrationBuilder.UpdateData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 6,
                column: "Name",
                value: "Hospitalizácia *");

            migrationBuilder.UpdateData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 10,
                column: "Name",
                value: "Aktuálne ochorenie alebo zhoršenie existujúceho ochorenia počas štúdie, ktoré si vyžaduje používanie liekov, ktoré nie sú povolené v spojení so súhrnom charakteristických vlastností lieku použitých liekov. *");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "de_4",
                table: "questionnaire_drug_effect09",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 5,
                column: "Name",
                value: "Smrť");

            migrationBuilder.UpdateData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 6,
                column: "Name",
                value: "Hospitalizácia");

            migrationBuilder.UpdateData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 10,
                column: "Name",
                value: "O alebo zhoršenie existujúceho ochorenia počas štúdie, ktoré si vyžaduje používanie liekov, ktoré nie sú povolené v spojení so súhrnom charakteristických vlastností lieku použitých liekov.");
        }
    }
}
