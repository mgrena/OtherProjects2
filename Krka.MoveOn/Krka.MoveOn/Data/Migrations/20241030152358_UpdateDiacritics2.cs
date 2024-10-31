using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Krka.MoveOn.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDiacritics2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 14,
                column: "Name",
                value: "Smrť");

            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 18,
                column: "Name",
                value: "Ťažká (Spôsobuje neschopnosť vykonávať bežné činnosti, pacient môže pociťovať neznesiteľné nepohodlie alebo bolesť)");

            migrationBuilder.UpdateData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 3,
                column: "Name",
                value: "Na diaľku prostredníctvom elektronických médií.");

            migrationBuilder.UpdateData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 4,
                column: "Name",
                value: "Výskyt závažnej nežiaducej reakcie počas pozorovacieho obdobia v tejto štúdii. *");

            migrationBuilder.UpdateData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 7,
                column: "Name",
                value: "Rozhodnutie pacienta ukončiť liečbu a odvolanie jeho informovaného súhlasu.");

            migrationBuilder.UpdateData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 8,
                column: "Name",
                value: "Rozhodnutie pacienta ukončiť liečbu a odvolanie informovaného súhlasu a GDPR formulára.");

            migrationBuilder.UpdateData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 9,
                column: "Name",
                value: "Bezpečnosť pacienta (napr. rozhodnutie skúšajúceho vylúčiť pacienta zo štúdie v jeho najlepšom záujme, nežiaduce účinky vyžadujúce medikamentózny zásah alebo ukončenie liečby). *");

            migrationBuilder.UpdateData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 10,
                column: "Name",
                value: "O alebo zhoršenie existujúceho ochorenia počas štúdie, ktoré si vyžaduje používanie liekov, ktoré nie sú povolené v spojení so súhrnom charakteristických vlastností lieku použitých liekov.");

            migrationBuilder.UpdateData(
                table: "dial_indications",
                keyColumn: "id",
                keyValue: 7,
                column: "Name",
                value: "Úzkosť");

            migrationBuilder.UpdateData(
                table: "dial_mhs",
                keyColumn: "id",
                keyValue: 2,
                column: "Name",
                value: "Jednostranné a axiálne príznaky (hypofónia, hypomímia, flekčné držanie tela) ");

            migrationBuilder.UpdateData(
                table: "dial_mhs",
                keyColumn: "id",
                keyValue: 5,
                column: "Name",
                value: "Mierne až stredné obojstranné príznaky, posturálna instabilita, pacient je stále sebestačný");

            migrationBuilder.UpdateData(
                table: "dial_mhs",
                keyColumn: "id",
                keyValue: 6,
                column: "Name",
                value: "Ťažké postihnutie, no pacient je schopný chodiť alebo stáť bez pomoci");

            migrationBuilder.UpdateData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 56,
                column: "Name",
                value: "Nič z vyššie uvedeného");

            migrationBuilder.UpdateData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 57,
                column: "Name",
                value: "Iná...");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 14,
                column: "Name",
                value: "Smrť");

            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 18,
                column: "Name",
                value: "Ťažká (Spôsobuje neschopnosť vykonávať bežné činnosti, pacient môže pociťovať neznesiteľné nepohodlie alebo bolesť)");

            migrationBuilder.UpdateData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 3,
                column: "Name",
                value: "Na diaľku prostredníctvom elektronických médií");

            migrationBuilder.UpdateData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 4,
                column: "Name",
                value: "Výskyt závažnej nežiaducej reakcie počas pozorovacieho obdobia v tejto štúdii");

            migrationBuilder.UpdateData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 7,
                column: "Name",
                value: "Rozhodnutie pacienta ukončiť liečbu a odvolanie jeho informovaného súhlasu");

            migrationBuilder.UpdateData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 8,
                column: "Name",
                value: "Rozhodnutie pacienta ukončiť liečbu a odvolanie informovaného súhlasu a GDPR formulára");

            migrationBuilder.UpdateData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 9,
                column: "Name",
                value: "Bezpečnosť pacienta (napr. rozhodnutie skúšajúceho vylúčiť pacienta zo štúdie v jeho najlepšom záujme, nežiaduce účinky vyžadujúce medikamentózny zásah alebo ukončenie liečby)");

            migrationBuilder.UpdateData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 10,
                column: "Name",
                value: "O alebo zhoršenie existujúceho ochorenia počas štúdie, ktoré si vyžaduje používanie liekov, ktoré nie sú povolené v spojení so súhrnom charakteristických vlastností lieku použitých liekov");

            migrationBuilder.UpdateData(
                table: "dial_indications",
                keyColumn: "id",
                keyValue: 7,
                column: "Name",
                value: "Úzkosť");

            migrationBuilder.UpdateData(
                table: "dial_mhs",
                keyColumn: "id",
                keyValue: 2,
                column: "Name",
                value: "Jednostranné a axiálne príznaky (hypofónia, hypomímia, flekčnédržanie tela)");

            migrationBuilder.UpdateData(
                table: "dial_mhs",
                keyColumn: "id",
                keyValue: 5,
                column: "Name",
                value: "Mierne až stredné obojstranné príznaky, posturálnainstabilita, pacient je stále sebestačný");

            migrationBuilder.UpdateData(
                table: "dial_mhs",
                keyColumn: "id",
                keyValue: 6,
                column: "Name",
                value: "Ťažké postihnutie, no pacient je schopný chodiť alebo stáť bez pomoci");

            migrationBuilder.UpdateData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 56,
                column: "Name",
                value: "Nič z vyššie uvedeného ");

            migrationBuilder.UpdateData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 57,
                column: "Name",
                value: "Iné...");
        }
    }
}
