using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace liriksi.WebAPI.Migrations
{
    public partial class usersSongRate6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Performer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    ArtisticName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Performer", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Song_PerformerId",
                table: "Song",
                column: "PerformerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Song_Performer_PerformerId",
                table: "Song",
                column: "PerformerId",
                principalTable: "Performer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Song_Performer_PerformerId",
                table: "Song");

            migrationBuilder.DropTable(
                name: "Performer");

            migrationBuilder.DropIndex(
                name: "IX_Song_PerformerId",
                table: "Song");
        }
    }
}
