using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Krka.MoveOn.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "dial_active_ingredient",
                columns: new[] { "id", "created_at", "indication_id", "modified_at", "Name", "type_q" },
                values: new object[] { 91, new DateTime(2025, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "žiadne", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "dial_active_ingredient",
                keyColumn: "id",
                keyValue: 91);
        }
    }
}
