using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Krka.MoveOn.Migrations
{
    /// <inheritdoc />
    public partial class DrugEffectDeletedAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "treat_2",
                table: "questionnaire_treatment03",
                type: "decimal(5,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.AddColumn<DateTime>(
                name: "deleted_at",
                table: "questionnaire_drug_effect09",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 55,
                column: "Name",
                value: "Iný parkinsonský syndróm");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "deleted_at",
                table: "questionnaire_drug_effect09");

            migrationBuilder.AlterColumn<decimal>(
                name: "treat_2",
                table: "questionnaire_treatment03",
                type: "decimal(5,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "dial_q_general",
                keyColumn: "id",
                keyValue: 55,
                column: "Name",
                value: "Iný parkinsonský syndróm ");
        }
    }
}
