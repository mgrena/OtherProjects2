using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Servier.Pressure.Migrations
{
    /// <inheritdoc />
    public partial class MonotherapyRepair : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DropColumn(
                name: "is_aldosterone_antagonist",
                table: "treatment_monotherapies");

            migrationBuilder.DropColumn(
                name: "is_aldosterone_antagonist",
                table: "list_treatment_monotherapy_drugs");

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 37,
                column: "monotherapy",
                value: 6);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 38,
                column: "monotherapy",
                value: 6);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 39,
                column: "monotherapy",
                value: 6);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 40,
                column: "monotherapy",
                value: 7);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 41,
                column: "monotherapy",
                value: 7);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 42,
                column: "monotherapy",
                value: 7);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 43,
                column: "monotherapy",
                value: 7);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 44,
                column: "monotherapy",
                value: 7);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 45,
                column: "monotherapy",
                value: 7);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "is_aldosterone_antagonist",
                table: "treatment_monotherapies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "is_aldosterone_antagonist",
                table: "list_treatment_monotherapy_drugs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 1,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 2,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 3,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 4,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 5,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 6,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 7,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 8,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 9,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 10,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 11,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 12,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 13,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 14,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 15,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 16,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 17,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 18,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 19,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 20,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 21,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 22,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 23,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 24,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 25,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 26,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 27,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 28,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 29,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 30,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 31,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 32,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 33,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 34,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 35,
                column: "is_aldosterone_antagonist",
                value: false);

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "is_aldosterone_antagonist", "monotherapy" },
                values: new object[] { true, 5 });

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "is_aldosterone_antagonist", "monotherapy" },
                values: new object[] { true, 5 });

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "is_aldosterone_antagonist", "monotherapy" },
                values: new object[] { true, 5 });

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "is_aldosterone_antagonist", "monotherapy" },
                values: new object[] { false, 6 });

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "is_aldosterone_antagonist", "monotherapy" },
                values: new object[] { false, 6 });

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "is_aldosterone_antagonist", "monotherapy" },
                values: new object[] { false, 6 });

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "is_aldosterone_antagonist", "monotherapy" },
                values: new object[] { false, 6 });

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "is_aldosterone_antagonist", "monotherapy" },
                values: new object[] { false, 6 });

            migrationBuilder.UpdateData(
                table: "list_treatment_monotherapy_drugs",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "is_aldosterone_antagonist", "monotherapy" },
                values: new object[] { false, 6 });

            migrationBuilder.InsertData(
                table: "list_treatment_monotherapy_drugs",
                columns: new[] { "id", "created_at", "deleted_at", "is_aldosterone_antagonist", "modified_at", "monotherapy", "drug", "order_number" },
                values: new object[] { 36, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "antagonista aldosterónu", 4 });
        }
    }
}
