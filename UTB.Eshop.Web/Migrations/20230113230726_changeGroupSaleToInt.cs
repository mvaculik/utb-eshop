using Microsoft.EntityFrameworkCore.Migrations;

namespace UTB.Eshop.Web.Migrations
{
    public partial class changeGroupSaleToInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Group",
                table: "Group");

            migrationBuilder.RenameTable(
                name: "Group",
                newName: "Groups");

            migrationBuilder.AlterColumn<int>(
                name: "Sale",
                table: "Groups",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Groups",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Groups",
                table: "Groups",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Sale",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2,
                column: "Sale",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3,
                column: "Sale",
                value: 50);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Groups",
                table: "Groups");

            migrationBuilder.RenameTable(
                name: "Groups",
                newName: "Group");

            migrationBuilder.AlterColumn<string>(
                name: "Sale",
                table: "Group",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Group",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Group",
                table: "Group",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "Id",
                keyValue: 1,
                column: "Sale",
                value: "0");

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "Id",
                keyValue: 2,
                column: "Sale",
                value: "10");

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "Id",
                keyValue: 3,
                column: "Sale",
                value: "25");
        }
    }
}
