using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLSV.Migrations
{
    public partial class Init_02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "RelativeUsers");

            migrationBuilder.RenameColumn(
                name: "IdentityId",
                table: "RelativeUsers",
                newName: "Fullname");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Fullname",
                table: "RelativeUsers",
                newName: "IdentityId");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "RelativeUsers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
