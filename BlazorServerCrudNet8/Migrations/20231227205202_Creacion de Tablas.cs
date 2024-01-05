using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerCrudNet8.Migrations
{
    /// <inheritdoc />
    public partial class CreaciondeTablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VIDEOGAME",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TITLE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PUBLISHER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RELEASE_YEAR = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VIDEOGAME", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "VIDEOGAME",
                columns: new[] { "ID", "PUBLISHER", "RELEASE_YEAR", "TITLE" },
                values: new object[,]
                {
                    { 1, "CD Projekt", 2020, "Cyberpunk 2077" },
                    { 2, "From Software", 2022, "Elden Ring" },
                    { 3, "Nintendo", 1998, "The Leyend of Zelda" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VIDEOGAME");
        }
    }
}
