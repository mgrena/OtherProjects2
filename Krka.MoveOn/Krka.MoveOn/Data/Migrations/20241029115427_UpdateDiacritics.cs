using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Krka.MoveOn.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDiacritics : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 2,
                column: "Name",
                value: "Občas");

            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 5,
                column: "Name",
                value: "Nepravdepodobne súvisí (udalosť s najväčšou pravdepodobnosťou nebola spôsobená liekom, ale príčinnú súvislosť nemožno úplne vylúčiť)");

            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 6,
                column: "Name",
                value: "Možno súvisí (Udalosť môže, ale nemusí byť spôsobená liekom, príčinnú súvislosť nie je možné posúdiť s väčšou istotou)");

            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 7,
                column: "Name",
                value: "Pravdepodobne súvisí (Liek je najpravdepodobnejšou príčinou udalosti, ale nemožno vylúčiť iné príčiny)");

            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 8,
                column: "Name",
                value: "Takmer určite súvisí (Liek je takmer určite príčinou udalosti, neexistujú žiadne iné zjavné alternatívne vysvetlenia)");

            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 11,
                column: "Name",
                value: "Hospitalizácia (začatá alebo predĺžená)");

            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 14,
                column: "Name",
                value: "Smrť");

            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 15,
                column: "Name",
                value: "Závažné podľa názoru skúšajúceho lekára");

            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 16,
                column: "Name",
                value: "Mierna (Nespôsobuje obmedzenie bežných činností, pacient môže pociťovať mierne nepohodlie)");

            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 17,
                column: "Name",
                value: "Stredne ťažká (Spôsobuje určité obmedzenia bežných aktivít, pacient môže pociťovať nepríjemné nepohodlie)");

            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 18,
                column: "Name",
                value: "Ťažká (Spôsobuje neschopnosť vykonávať bežné činnosti, pacient môže pociťovať neznesiteľné nepohodlie alebo bolesť)");

            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 20,
                column: "Name",
                value: "Zmeny v liečbe");

            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 22,
                column: "Name",
                value: "Symptomatická liečba");

            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 25,
                column: "Name",
                value: "Pokračuje");

            migrationBuilder.UpdateData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 2,
                column: "Name",
                value: "Na diaľku prostredníctvom telefonického hovoru");

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
                keyValue: 5,
                column: "Name",
                value: "Smrť");

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
                value: "Bezpečnosť pacienta (napr. rozhodnutie skúšajúceho vylúčiť pacienta zo štúdie v jeho najlepšom záujme, nežiaduce účinky vyžadujúce medikamentózny zásah alebo ukončenie liečby).  *");

            migrationBuilder.UpdateData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 10,
                column: "Name",
                value: "O alebo zhoršenie existujúceho ochorenia počas štúdie, ktoré si vyžaduje používanie liekov, ktoré nie sú povolené v spojení so súhrnom charakteristických vlastností lieku použitých liekov");

            migrationBuilder.UpdateData(
                table: "dial_indications",
                keyColumn: "id",
                keyValue: 1,
                column: "Name",
                value: "Pruhy močenia");

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
                keyValue: 4,
                column: "Name",
                value: "Obojstranné príznaky s miernou poruchou rovnováhy (schopnosť vyrovnať postoj pri pull teste)");

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
                table: "dial_mhs",
                keyColumn: "id",
                keyValue: 7,
                column: "Name",
                value: "Pacient je odkázaný na vozík alebo posteľ");

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
                value: "Depresia alebo úzkosť");

            migrationBuilder.UpdateData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 55,
                column: "Name",
                value: "Iný parkinsonský syndróm");

            migrationBuilder.UpdateData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 56,
                column: "Name",
                value: "Nič z vyššie uvedeného");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 2,
                column: "Name",
                value: "Obèas");

            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 5,
                column: "Name",
                value: "Nepravdepodobne súvisí (udalos s najväèšou pravdepodobnosou nebola spôsobená liekom, ale príèinnú súvislos nemožno úplne vylúèi)");

            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 6,
                column: "Name",
                value: "Možno súvisí (Udalos môže, ale nemusí by spôsobená liekom, príèinnú súvislos nie je možné posúdi s väèšou istotou)");

            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 7,
                column: "Name",
                value: "Pravdepodobne súvisí (Liek je najpravdepodobnejšou príèinou udalosti, ale nemožno vylúèi iné príèiny)");

            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 8,
                column: "Name",
                value: "Takmer urèite súvisí (Liek je takmer urèite príèinou udalosti, neexistujú žiadne iné zjavné alternatívne vysvetlenia)");

            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 11,
                column: "Name",
                value: "Hospitalizácia (zaèatá alebo predåžená)");

            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 14,
                column: "Name",
                value: "Smr");

            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 15,
                column: "Name",
                value: "Závažné pod¾a názoru skúšajúceho lekára");

            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 16,
                column: "Name",
                value: "Mierna (Nespôsobuje obmedzenie bežných èinností, pacient môže pociova mierne nepohodlie)");

            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 17,
                column: "Name",
                value: "Stredne ažká (Spôsobuje urèité obmedzenia bežných aktivít, pacient môže pociova nepríjemné nepohodlie)");

            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 18,
                column: "Name",
                value: "ažká (Spôsobuje neschopnos vykonáva bežné èinnosti, pacient môže pociova neznesite¾né nepohodlie alebo boles)");

            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 20,
                column: "Name",
                value: "Zmeny v lieèbe");

            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 22,
                column: "Name",
                value: "Symptomatická lieèba");

            migrationBuilder.UpdateData(
                table: "dial_adverse_effects",
                keyColumn: "id",
                keyValue: 25,
                column: "Name",
                value: "Pokraèuje");

            migrationBuilder.UpdateData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 2,
                column: "Name",
                value: "Na dia¾ku prostredníctvom telefonického hovoru");

            migrationBuilder.UpdateData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 3,
                column: "Name",
                value: "Na dia¾ku prostredníctvom elektronických médií");

            migrationBuilder.UpdateData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 4,
                column: "Name",
                value: "Výskyt závažnej nežiaducej reakcie poèas pozorovacieho obdobia v tejto štúdii");

            migrationBuilder.UpdateData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 5,
                column: "Name",
                value: "Smr");

            migrationBuilder.UpdateData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 7,
                column: "Name",
                value: "Rozhodnutie pacienta ukonèi lieèbu a odvolanie jeho informovaného súhlasu");

            migrationBuilder.UpdateData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 8,
                column: "Name",
                value: "Rozhodnutie pacienta ukonèi lieèbu a odvolanie informovaného súhlasu a GDPR formulára");

            migrationBuilder.UpdateData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 9,
                column: "Name",
                value: "Bezpeènos pacienta (napr. rozhodnutie skúšajúceho vylúèi pacienta zo štúdie v jeho najlepšom záujme, nežiaduce úèinky vyžadujúce medikamentózny zásah alebo ukonèenie lieèby)");

            migrationBuilder.UpdateData(
                table: "dial_exlusions",
                keyColumn: "id",
                keyValue: 10,
                column: "Name",
                value: "O alebo zhoršenie existujúceho ochorenia poèas štúdie, ktoré si vyžaduje používanie liekov, ktoré nie sú povolené v spojení so súhrnom charakteristických vlastností lieku použitých liekov");

            migrationBuilder.UpdateData(
                table: "dial_indications",
                keyColumn: "id",
                keyValue: 1,
                column: "Name",
                value: "Pruhy moèenia");

            migrationBuilder.UpdateData(
                table: "dial_indications",
                keyColumn: "id",
                keyValue: 7,
                column: "Name",
                value: "Úzkos");

            migrationBuilder.UpdateData(
                table: "dial_mhs",
                keyColumn: "id",
                keyValue: 2,
                column: "Name",
                value: "Jednostranné a axiálne príznaky (hypofónia, hypomímia, flekènédržanie tela)");

            migrationBuilder.UpdateData(
                table: "dial_mhs",
                keyColumn: "id",
                keyValue: 4,
                column: "Name",
                value: "Obojstranné príznaky s miernou poruchou rovnováhy (schopnos vyrovna postoj pri pull teste)");

            migrationBuilder.UpdateData(
                table: "dial_mhs",
                keyColumn: "id",
                keyValue: 5,
                column: "Name",
                value: "Mierne až stredné obojstranné príznaky, posturálnainstabilita, pacient je stále sebestaèný");

            migrationBuilder.UpdateData(
                table: "dial_mhs",
                keyColumn: "id",
                keyValue: 6,
                column: "Name",
                value: "ažké postihnutie, no pacient je schopný chodi alebo stá bez pomoci");

            migrationBuilder.UpdateData(
                table: "dial_mhs",
                keyColumn: "id",
                keyValue: 7,
                column: "Name",
                value: "Pacient je odkázaný na vozík alebo poste¾");

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
                keyValue: 55,
                column: "Name",
                value: "Iný parkinsonský syndróm ");

            migrationBuilder.UpdateData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 56,
                column: "Name",
                value: "Niè z vyššie uvedeného ");
        }
    }
}
