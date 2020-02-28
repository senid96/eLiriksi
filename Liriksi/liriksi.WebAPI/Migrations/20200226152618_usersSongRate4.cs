using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace liriksi.WebAPI.Migrations
{
    public partial class usersSongRate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Album_Performer_PerformerId",
                table: "Album");

            migrationBuilder.DropTable(
                name: "Performer");

            migrationBuilder.DropIndex(
                name: "IX_Album_PerformerId",
                table: "Album");

            migrationBuilder.DropColumn(
                name: "PerformerId",
                table: "Album");

            migrationBuilder.AddColumn<int>(
                name: "PerformerId",
                table: "Song",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PerformerId",
                table: "Song");

            migrationBuilder.AddColumn<int>(
                name: "PerformerId",
                table: "Album",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Performer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArtisticName = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Performer", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Album_PerformerId",
                table: "Album",
                column: "PerformerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Album_Performer_PerformerId",
                table: "Album",
                column: "PerformerId",
                principalTable: "Performer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
