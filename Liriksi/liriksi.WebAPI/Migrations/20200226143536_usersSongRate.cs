using Microsoft.EntityFrameworkCore.Migrations;

namespace liriksi.WebAPI.Migrations
{
    public partial class usersSongRate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsersSongRates",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    SongId = table.Column<int>(nullable: false),
                    Rate = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersSongRates", x => new { x.SongId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UsersSongRates_Song_SongId",
                        column: x => x.SongId,
                        principalTable: "Song",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersSongRates_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersSongRates_UserId",
                table: "UsersSongRates",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersSongRates");
        }
    }
}
