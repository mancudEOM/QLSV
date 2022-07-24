using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLSV.Migrations
{
    public partial class Init_relationship_User_Historyrent_Room : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "HistoryRents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_HistoryRents_UserId",
                table: "HistoryRents",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HistoryRents_Users_UserId",
                table: "HistoryRents",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistoryRents_Users_UserId",
                table: "HistoryRents");

            migrationBuilder.DropIndex(
                name: "IX_HistoryRents_UserId",
                table: "HistoryRents");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "HistoryRents");
        }
    }
}
