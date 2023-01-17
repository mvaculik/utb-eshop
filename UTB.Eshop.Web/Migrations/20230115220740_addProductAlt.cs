using Microsoft.EntityFrameworkCore.Migrations;

namespace UTB.Eshop.Web.Migrations
{
    public partial class addProductAlt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageSrc",
                table: "Product",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ImageAlt",
                table: "Product",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1,
                column: "ImageAlt",
                value: "Bulbasaur");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 2,
                column: "ImageAlt",
                value: "Charmeleon");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 3,
                column: "ImageAlt",
                value: "Metapod");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 4,
                column: "ImageAlt",
                value: "Kakuna");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 5,
                column: "ImageAlt",
                value: "Ekans");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageAlt",
                table: "Product");

            migrationBuilder.AlterColumn<string>(
                name: "ImageSrc",
                table: "Product",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
