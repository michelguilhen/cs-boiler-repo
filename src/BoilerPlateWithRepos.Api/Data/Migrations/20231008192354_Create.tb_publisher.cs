using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BoilerPlateWithRepos.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Createtb_publisher : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "publisher_id",
                table: "tb_game",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "tb_publisher",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_publisher", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_game_publisher_id",
                table: "tb_game",
                column: "publisher_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_publisher_name",
                table: "tb_publisher",
                column: "name");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_game_tb_publisher_publisher_id",
                table: "tb_game",
                column: "publisher_id",
                principalTable: "tb_publisher",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_game_tb_publisher_publisher_id",
                table: "tb_game");

            migrationBuilder.DropTable(
                name: "tb_publisher");

            migrationBuilder.DropIndex(
                name: "IX_tb_game_publisher_id",
                table: "tb_game");

            migrationBuilder.DropColumn(
                name: "publisher_id",
                table: "tb_game");
        }
    }
}
