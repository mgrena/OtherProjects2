using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Krka.MoveOn.Migrations
{
    /// <inheritdoc />
    public partial class Workplaces : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "id_workplace",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "WorkPlaces",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    workplace = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkPlaces", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "WorkPlaces",
                columns: new[] { "id", "created_at", "deleted_at", "workplace" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "nepriradené" },
                    { 2, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Neurologické oddelenie, Nemocnica AGEL Zvolen a.s." },
                    { 3, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Neurologické oddelenie UNB Bratislava - Kramáre" },
                    { 4, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Neurologické oddelenie UNB Bratislava - Ružinov" },
                    { 5, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Neurologické oddelenie, FN Trnava" },
                    { 6, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Neurologické oddelenie, FN Nitra" },
                    { 7, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Neurologické oddelenie, UN Martin" },
                    { 8, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Neurologické oddelenie ÚVN Ružomberok" },
                    { 9, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Neurologické oddelenie, NsP Sv. Jakuba n.o., Bardejov" },
                    { 10, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Neurologická klinika, UN Louisa Pasteura, Košice" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkPlaces");

            migrationBuilder.DropColumn(
                name: "id_workplace",
                table: "AspNetUsers");
        }
    }
}
