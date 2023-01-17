using Microsoft.EntityFrameworkCore.Migrations;

namespace UTB.Eshop.Web.Migrations
{
    public partial class addStaturRowForCoupons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Coupon",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Coupon",
                keyColumn: "ID",
                keyValue: 1,
                column: "Status",
                value: "0");

            migrationBuilder.UpdateData(
                table: "Coupon",
                keyColumn: "ID",
                keyValue: 2,
                column: "Status",
                value: "0");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Coupon");
        }
    }
}
