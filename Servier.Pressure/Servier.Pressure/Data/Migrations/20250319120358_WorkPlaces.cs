using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Servier.Pressure.Migrations
{
    /// <inheritdoc />
    public partial class WorkPlaces : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "first_name",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lst_name",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "title_after",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "title_before",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "logs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    log_level = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    id_user = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    category = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_logs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "workplaces",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    workplace_type = table.Column<int>(type: "int", nullable: false),
                    specialization = table.Column<int>(type: "int", nullable: false),
                    count_all = table.Column<int>(type: "int", nullable: false),
                    count_all_unknown = table.Column<bool>(type: "bit", nullable: false),
                    count_AH = table.Column<int>(type: "int", nullable: false),
                    count_AH_unknown = table.Column<bool>(type: "bit", nullable: false),
                    workplace = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    id_user = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_workplaces", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "logs");

            migrationBuilder.DropTable(
                name: "workplaces");

            migrationBuilder.DropColumn(
                name: "first_name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "lst_name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "title_after",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "title_before",
                table: "AspNetUsers");
        }
    }
}
