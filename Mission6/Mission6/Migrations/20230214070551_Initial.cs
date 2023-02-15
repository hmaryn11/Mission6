using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    movieTitle = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    directorName = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    lentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "Category", "Edited", "Notes", "Rating", "Year", "directorName", "lentTo", "movieTitle" },
                values: new object[] { 1, "Romantic Comedy", true, null, "PG-13", 2003, "Donald Petrie", "", "How To Lose A Guy In Ten Days" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "Category", "Edited", "Notes", "Rating", "Year", "directorName", "lentTo", "movieTitle" },
                values: new object[] { 2, "Action/Adventure", true, null, "PG", 2017, "Chris McKay", "", "The Lego Batman Movie" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "Category", "Edited", "Notes", "Rating", "Year", "directorName", "lentTo", "movieTitle" },
                values: new object[] { 3, "Drama/Comedy", true, null, "PG", 1946, "Frank Capra", "", "It's A Wonderful Life" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
