
using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoilerPlateWithRepos.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Createtb_game : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "game",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_game", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_game_name",
                table: "game",
                column: "name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "game");
        }
    }
}
