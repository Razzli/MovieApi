using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieApi.Migrations
{
    /// <inheritdoc />
    public partial class Reviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_MovieDetails_MovieDetailsID",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_MovieDetailsID",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "MovieDetailsID",
                table: "Movie");

            migrationBuilder.AddColumn<int>(
                name: "MovieID",
                table: "MovieDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    MovieID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_Movie_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieDetails_MovieID",
                table: "MovieDetails",
                column: "MovieID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Review_MovieID",
                table: "Review",
                column: "MovieID");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieDetails_Movie_MovieID",
                table: "MovieDetails",
                column: "MovieID",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieDetails_Movie_MovieID",
                table: "MovieDetails");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropIndex(
                name: "IX_MovieDetails_MovieID",
                table: "MovieDetails");

            migrationBuilder.DropColumn(
                name: "MovieID",
                table: "MovieDetails");

            migrationBuilder.AddColumn<int>(
                name: "MovieDetailsID",
                table: "Movie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Movie_MovieDetailsID",
                table: "Movie",
                column: "MovieDetailsID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_MovieDetails_MovieDetailsID",
                table: "Movie",
                column: "MovieDetailsID",
                principalTable: "MovieDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
