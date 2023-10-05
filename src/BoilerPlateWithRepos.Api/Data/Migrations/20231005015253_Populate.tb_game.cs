using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BoilerPlateWithRepos.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Populatetb_game : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "game",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { new Guid("2cd305a3-55ec-484c-9df1-adc7bc7c417c"), "ble ble", "Crash Bandicoot" },
                    { new Guid("b60f059a-2cd8-48ee-b4c0-db3e577f081f"), "bla bla", "Elden Ring" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "game",
                keyColumn: "id",
                keyValue: new Guid("2cd305a3-55ec-484c-9df1-adc7bc7c417c"));

            migrationBuilder.DeleteData(
                table: "game",
                keyColumn: "id",
                keyValue: new Guid("b60f059a-2cd8-48ee-b4c0-db3e577f081f"));
        }
    }
}
