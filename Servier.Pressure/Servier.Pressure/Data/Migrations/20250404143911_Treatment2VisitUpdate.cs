using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Servier.Pressure.Migrations
{
    /// <inheritdoc />
    public partial class Treatment2VisitUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "is_properly_terminated",
                table: "treatments_2_visit",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "is_returned_recorder",
                table: "treatments_2_visit",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "subject_evaluation",
                table: "treatments_2_visit",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "termination_reason",
                table: "treatments_2_visit",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "visit_date",
                table: "treatments_2_visit",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_properly_terminated",
                table: "treatments_2_visit");

            migrationBuilder.DropColumn(
                name: "is_returned_recorder",
                table: "treatments_2_visit");

            migrationBuilder.DropColumn(
                name: "subject_evaluation",
                table: "treatments_2_visit");

            migrationBuilder.DropColumn(
                name: "termination_reason",
                table: "treatments_2_visit");

            migrationBuilder.DropColumn(
                name: "visit_date",
                table: "treatments_2_visit");
        }
    }
}
