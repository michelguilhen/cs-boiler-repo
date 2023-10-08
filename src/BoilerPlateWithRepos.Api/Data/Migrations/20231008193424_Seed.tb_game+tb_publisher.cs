using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoilerPlateWithRepos.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Seedtb_gametb_publisher : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tb_publisher",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { new Guid("8ee47290-f1a6-4bbd-8cba-3b4060c5fd89"), "It sucks", "Activision" },
                    { new Guid("cbdb5950-1c6c-4b24-a60f-d2a0960487d2"), "Average", "Bandai Namco" }
                });

            migrationBuilder.InsertData(
                table: "tb_game",
                columns: new[] { "id", "description", "name", "publisher_id" },
                values: new object[,]
                {
                    { new Guid("11aabf3a-7e41-4353-9642-1d3bf5dc8fb5"), "Good", "Crash Bandicoot", "8ee47290-f1a6-4bbd-8cba-3b4060c5fd89" },
                    { new Guid("3d70cbc6-5978-4eb9-a05f-7ff91710820b"), "Great", "Elden Ring", "cbdb5950-1c6c-4b24-a60f-d2a0960487d2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from tb_game", true);
            migrationBuilder.Sql("delete from tb_publisher", true);
        }
    }
}
