using Microsoft.EntityFrameworkCore.Migrations;

namespace UTB.Eshop.Web.Migrations
{
    public partial class addProductImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageSrc",
                table: "Product",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1,
                column: "ImageSrc",
                value: "/img/carousel/wallpapersden.com_pokemon-4k-cool_3840x2400.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 2,
                column: "ImageSrc",
                value: "/img/carousel/wallpapersden.com_pokemon-4k-cool_3840x2400.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 3,
                column: "ImageSrc",
                value: "/img/carousel/wallpapersden.com_pokemon-4k-cool_3840x2400.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 4,
                column: "ImageSrc",
                value: "/img/carousel/wallpapersden.com_pokemon-4k-cool_3840x2400.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 5,
                column: "ImageSrc",
                value: "/img/carousel/wallpapersden.com_pokemon-4k-cool_3840x2400.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageSrc",
                table: "Product");
        }
    }
}
