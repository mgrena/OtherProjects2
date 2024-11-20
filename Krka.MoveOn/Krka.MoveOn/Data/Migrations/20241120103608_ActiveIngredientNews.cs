using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Krka.MoveOn.Migrations
{
    /// <inheritdoc />
    public partial class ActiveIngredientNews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "indication_id",
                table: "dial_active_ingredient",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 1,
                column: "indication_id",
                value: null);

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 2,
                column: "indication_id",
                value: null);

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 3,
                column: "indication_id",
                value: null);

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 4,
                column: "indication_id",
                value: null);

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 5,
                column: "indication_id",
                value: null);

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 6,
                column: "indication_id",
                value: null);

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 7,
                column: "indication_id",
                value: null);

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 8,
                column: "indication_id",
                value: null);

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 9,
                column: "indication_id",
                value: null);

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 10,
                column: "indication_id",
                value: null);

            migrationBuilder.UpdateData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 11,
                column: "indication_id",
                value: null);

            migrationBuilder.InsertData(
                table: "dial_active_ingredient",
                columns: new[] { "id", "created_at", "indication_id", "modified_at", "Name", "type_q" },
                values: new object[,]
                {
                    { 12, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Solifenacín", 2 },
                    { 13, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mirabegron", 2 },
                    { 14, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trospium", 2 },
                    { 15, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avanafil", 2 },
                    { 16, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iné...", 2 },
                    { 17, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sildenafil", 2 },
                    { 18, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tadalafil", 2 },
                    { 19, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avanafil", 2 },
                    { 20, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iné...", 2 },
                    { 21, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bisakodyl", 2 },
                    { 22, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laklulóza", 2 },
                    { 23, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Makrogol", 2 },
                    { 24, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Binatriumpikosulfát", 2 },
                    { 25, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prukaloprid", 2 },
                    { 26, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Glycerol", 2 },
                    { 27, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iné...", 2 },
                    { 28, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Klonazepam", 2 },
                    { 29, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Melatonín", 2 },
                    { 30, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zopiklón", 2 },
                    { 31, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eszopiklón", 2 },
                    { 32, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zolpidem", 2 },
                    { 33, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cinalozepam", 2 },
                    { 34, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iné...", 2 },
                    { 35, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Donepezil", 2 },
                    { 36, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rivastigmín", 2 },
                    { 37, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Galantamín", 2 },
                    { 38, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ginkgo biloba", 2 },
                    { 39, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Memantín", 2 },
                    { 40, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iné...", 2 },
                    { 41, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Midodrin", 2 },
                    { 42, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fludrokortizón", 2 },
                    { 43, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iné...", 2 },
                    { 44, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agomelatín", 2 },
                    { 45, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Venlafaxín", 2 },
                    { 46, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amitriptylín", 2 },
                    { 47, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Imipramín", 2 },
                    { 48, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Klomipramín", 2 },
                    { 49, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paroxetín", 2 },
                    { 50, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moklobemid", 2 },
                    { 51, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vortioxetín", 2 },
                    { 52, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bupropion", 2 },
                    { 53, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Citalopram", 2 },
                    { 54, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Escitalopram", 2 },
                    { 55, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tianeptín", 2 },
                    { 56, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Duloxetín", 2 },
                    { 57, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mirtazapín", 2 },
                    { 58, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fluvoxamín", 2 },
                    { 59, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fluoxetín", 2 },
                    { 60, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mianserín", 2 },
                    { 61, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lítium", 2 },
                    { 62, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sertralín", 2 },
                    { 63, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trazodon", 2 },
                    { 64, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iné...", 2 },
                    { 65, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diazepam", 2 },
                    { 66, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hydroxyzín", 2 },
                    { 67, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bromazepam", 2 },
                    { 68, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buspirón", 2 },
                    { 69, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alprazolam", 2 },
                    { 70, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chlórdiazepoxid", 2 },
                    { 71, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tofizopam", 2 },
                    { 72, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iné...", 2 },
                    { 73, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aripiprazol", 2 },
                    { 74, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amilsulprid", 2 },
                    { 75, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sulpirid", 2 },
                    { 76, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Olanzapín", 2 },
                    { 77, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zuklopentixol", 2 },
                    { 78, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Klozapín", 2 },
                    { 79, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kvetiapín", 2 },
                    { 80, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Palliperidón", 2 },
                    { 81, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tiapridal", 2 },
                    { 82, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Haloperidol", 2 },
                    { 83, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lurazidón", 2 },
                    { 84, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lítium", 2 },
                    { 85, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kariprazín", 2 },
                    { 86, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Risperinón", 2 },
                    { 87, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sertindol", 2 },
                    { 88, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziprasidón", 2 },
                    { 89, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zotepín", 2 },
                    { 90, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iné...", 2 }
                });

            migrationBuilder.InsertData(
                table: "dial_indications",
                columns: new[] { "id", "created_at", "modified_at", "Name", "type_q" },
                values: new object[] { 10, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Poruchy pamäti a kognície", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "dial_indications",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "indication_id",
                table: "dial_active_ingredient");
        }
    }
}
