using Microsoft.EntityFrameworkCore.Migrations;

namespace liriksi.WebAPI.Migrations
{
    public partial class removePerformerFromSong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Performer_Song_PerformerId",
                table: "Performer");

            migrationBuilder.DropIndex(
                name: "IX_Performer_PerformerId",
                table: "Performer");

            migrationBuilder.DropColumn(
                name: "PerformerId",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "PerformerId",
                table: "Performer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PerformerId",
                table: "Song",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PerformerId",
                table: "Performer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Performer_PerformerId",
                table: "Performer",
                column: "PerformerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Performer_Song_PerformerId",
                table: "Performer",
                column: "PerformerId",
                principalTable: "Song",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
