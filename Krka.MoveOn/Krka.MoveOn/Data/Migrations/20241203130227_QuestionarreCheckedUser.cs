using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Krka.MoveOn.Migrations
{
    /// <inheritdoc />
    public partial class QuestionarreCheckedUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "checked_at",
                table: "questionnaires",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_user",
                table: "questionnaires",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "checked_at",
                table: "questionnaires");

            migrationBuilder.DropColumn(
                name: "id_user",
                table: "questionnaires");
        }
    }
}
