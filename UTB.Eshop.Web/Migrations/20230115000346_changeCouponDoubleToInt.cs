using Microsoft.EntityFrameworkCore.Migrations;

namespace UTB.Eshop.Web.Migrations
{
    public partial class changeCouponDoubleToInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Sale",
                table: "Coupon",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.UpdateData(
                table: "Coupon",
                keyColumn: "ID",
                keyValue: 1,
                column: "Sale",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Coupon",
                keyColumn: "ID",
                keyValue: 2,
                column: "Sale",
                value: 25);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Sale",
                table: "Coupon",
                type: "double",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Coupon",
                keyColumn: "ID",
                keyValue: 1,
                column: "Sale",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "Coupon",
                keyColumn: "ID",
                keyValue: 2,
                column: "Sale",
                value: 25.0);
        }
    }
}
