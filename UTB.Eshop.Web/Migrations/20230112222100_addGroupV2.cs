using Microsoft.EntityFrameworkCore.Migrations;

namespace UTB.Eshop.Web.Migrations
{
    public partial class addGroupV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Groupname",
                table: "Users",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Groupname",
                table: "Users");
        }
    }
}
