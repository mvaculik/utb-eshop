using Microsoft.EntityFrameworkCore.Migrations;

namespace UTB.Eshop.Web.Migrations
{
    public partial class updateProductsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarouselItem",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "CarouselItem",
                keyColumn: "ID",
                keyValue: 1,
                column: "ImageSrc",
                value: "/img/carousel/95-954600_pokemon-card-wallpaper.jpg");

            migrationBuilder.UpdateData(
                table: "CarouselItem",
                keyColumn: "ID",
                keyValue: 2,
                column: "ImageSrc",
                value: "/img/carousel/wallpapersden.com_pokemon-4k-cool_3840x2400.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Bulbasaur", 150.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 2,
                column: "Name",
                value: "Charmeleon");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 3,
                column: "Name",
                value: "Metapod");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 4,
                column: "Name",
                value: "Kakuna");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 5,
                column: "Name",
                value: "Ekans");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CarouselItem",
                keyColumn: "ID",
                keyValue: 1,
                column: "ImageSrc",
                value: "/img/carousel/information-technology-1.jpg");

            migrationBuilder.UpdateData(
                table: "CarouselItem",
                keyColumn: "ID",
                keyValue: 2,
                column: "ImageSrc",
                value: "/img/carousel/how-to-become-an-information-technology-specialist160684886950141.jpg");

            migrationBuilder.InsertData(
                table: "CarouselItem",
                columns: new[] { "ID", "ImageAlt", "ImageSrc" },
                values: new object[] { 3, "Third slide", "/img/carousel/1581481407499.jpeg" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Chleba", 100.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 2,
                column: "Name",
                value: "Máslo");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 3,
                column: "Name",
                value: "Perlivě neperlivá voda");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 4,
                column: "Name",
                value: "Tácek");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 5,
                column: "Name",
                value: "Ubrousky");
        }
    }
}
