using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLSV.Migrations
{
    public partial class Init01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistoryBill_Users_UserId",
                table: "HistoryBill");

            migrationBuilder.DropIndex(
                name: "IX_HistoryBill_UserId",
                table: "HistoryBill");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "HistoryBill");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "HistoryBill",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HistoryBill_UserId",
                table: "HistoryBill",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_HistoryBill_Users_UserId",
                table: "HistoryBill",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
