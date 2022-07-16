using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLSV.Migrations
{
    public partial class Init_relationship_User_RelativeUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "RelativeUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RelativeUsers_UserId",
                table: "RelativeUsers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RelativeUsers_Users_UserId",
                table: "RelativeUsers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RelativeUsers_Users_UserId",
                table: "RelativeUsers");

            migrationBuilder.DropIndex(
                name: "IX_RelativeUsers_UserId",
                table: "RelativeUsers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "RelativeUsers");
        }
    }
}
