using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace liriksi.WebAPI.Migrations
{
    public partial class addgenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Album",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Album_GenreId",
                table: "Album",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Album_Genre_GenreId",
                table: "Album",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Album_Genre_GenreId",
                table: "Album");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropIndex(
                name: "IX_Album_GenreId",
                table: "Album");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Album");
        }
    }
}
