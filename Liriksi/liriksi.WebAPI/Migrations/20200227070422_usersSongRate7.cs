using Microsoft.EntityFrameworkCore.Migrations;

namespace liriksi.WebAPI.Migrations
{
    public partial class usersSongRate7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_UsersAlbumRates_UserId",
                table: "UsersAlbumRates",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_CityId",
                table: "User",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_City_CityId",
                table: "User",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_City_CityId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersAlbumRates_Album_AlbumId",
                table: "UsersAlbumRates");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersAlbumRates_User_UserId",
                table: "UsersAlbumRates");

            migrationBuilder.DropIndex(
                name: "IX_UsersAlbumRates_UserId",
                table: "UsersAlbumRates");

            migrationBuilder.DropIndex(
                name: "IX_User_CityId",
                table: "User");
        }
    }
}
