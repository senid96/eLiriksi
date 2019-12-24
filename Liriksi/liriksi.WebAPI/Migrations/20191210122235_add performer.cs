using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace liriksi.WebAPI.Migrations
{
    public partial class addperformer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_UserType_UserTypeId",
                table: "User");

            migrationBuilder.AlterColumn<int>(
                name: "UserTypeId",
                table: "User",
                nullable: true,
                oldClrType: typeof(int));

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
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    ArtisticName = table.Column<string>(nullable: true)
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

            migrationBuilder.AddForeignKey(
                name: "FK_User_UserType_UserTypeId",
                table: "User",
                column: "UserTypeId",
                principalTable: "UserType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Album_Performer_PerformerId",
                table: "Album");

            migrationBuilder.DropForeignKey(
                name: "FK_User_UserType_UserTypeId",
                table: "User");

            migrationBuilder.DropTable(
                name: "Performer");

            migrationBuilder.DropIndex(
                name: "IX_Album_PerformerId",
                table: "Album");

            migrationBuilder.DropColumn(
                name: "PerformerId",
                table: "Album");

            migrationBuilder.AlterColumn<int>(
                name: "UserTypeId",
                table: "User",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_User_UserType_UserTypeId",
                table: "User",
                column: "UserTypeId",
                principalTable: "UserType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
