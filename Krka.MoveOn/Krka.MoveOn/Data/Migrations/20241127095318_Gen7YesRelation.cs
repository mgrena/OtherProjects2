using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Krka.MoveOn.Migrations
{
    /// <inheritdoc />
    public partial class Gen7YesRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "rel_Gen7Yes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenQuestId = table.Column<int>(type: "int", nullable: true),
                    gen_7_1_dm = table.Column<int>(type: "int", nullable: true),
                    gen_7_2 = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    gen_7_4 = table.Column<decimal>(type: "decimal(3,1)", nullable: true),
                    gen_7_1_1 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    gen_7_1_2 = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    gen_7_1_4 = table.Column<decimal>(type: "decimal(3,1)", nullable: true),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rel_Gen7Yes", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "rel_Gen7Yes");
        }
    }
}
