using Microsoft.EntityFrameworkCore.Migrations;

namespace liriksi.WebAPI.Migrations
{
    public partial class usersSongRate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersAlbumRates_Album_AlbumId",
                table: "UsersAlbumRates");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersAlbumRates_User_UserId",
                table: "UsersAlbumRates");

            migrationBuilder.DropIndex(
                name: "IX_UsersAlbumRates_UserId",
                table: "UsersAlbumRates");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_UsersAlbumRates_UserId",
                table: "UsersAlbumRates",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersAlbumRates_Album_AlbumId",
                table: "UsersAlbumRates",
                column: "AlbumId",
                principalTable: "Album",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersAlbumRates_User_UserId",
                table: "UsersAlbumRates",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
