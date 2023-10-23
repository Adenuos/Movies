using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Movie_SlutProjekt.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Duration", "Genre", "Rating", "Title", "Year" },
                values: new object[,]
                {
                    { 1, "Frank Darabont", 142, "Drama", 9.3000000000000007, "The Shawshank Redemption", 1994 },
                    { 2, "Francis Ford Coppola", 175, "Crime, Drama", 9.1999999999999993, "The Godfather", 1972 },
                    { 3, "Christopher Nolan", 152, "Action, Crime, Drama", 9.0, "The Dark Knight", 2008 },
                    { 4, "Quentin Tarantino", 154, "Crime, Drama", 8.9000000000000004, "Pulp Fiction", 1994 },
                    { 5, "David Fincher", 139, "Drama", 8.8000000000000007, "Fight Club", 1999 },
                    { 6, "Robert Zemeckis", 142, "Drama, Romance", 8.8000000000000007, "Forrest Gump", 1994 },
                    { 7, "Christopher Nolan", 148, "Action, Adventure, Sci-Fi", 8.6999999999999993, "Inception", 2010 },
                    { 8, "Lana Wachowski, Lilly Wachowski", 136, "Action, Sci-Fi", 8.6999999999999993, "The Matrix", 1999 },
                    { 9, "Christopher Nolan", 169, "Adventure, Drama, Sci-Fi", 8.5999999999999996, "Interstellar", 2014 },
                    { 10, "Peter Jackson", 178, "Adventure, Drama, Fantasy", 8.8000000000000007, "The Lord of the Rings: The Fellowship of the Ring", 2001 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
