using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieApi.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieDetails_Movie_MovieID",
                table: "MovieDetails");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_MovieDetails_MovieID",
                table: "MovieDetails",
                column: "MovieID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieDetails_Movie_MovieID",
                table: "MovieDetails",
                column: "MovieID",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
