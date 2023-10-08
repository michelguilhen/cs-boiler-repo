using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BoilerPlateWithRepos.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Createtb_game : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_game",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_game", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "tb_game",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { new Guid("2cd305a3-55ec-484c-9df1-adc7bc7c417c"), "ble ble", "Crash Bandicoot" },
                    { new Guid("b60f059a-2cd8-48ee-b4c0-db3e577f081f"), "bla bla", "Elden Ring" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_game_name",
                table: "tb_game",
                column: "name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_game");
        }
    }
}
