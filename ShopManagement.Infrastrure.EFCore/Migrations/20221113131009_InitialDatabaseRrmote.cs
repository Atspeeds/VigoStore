using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopManagement.Infrastrure.EFCore.Migrations
{
    public partial class InitialDatabaseRrmote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsInStock = table.Column<bool>(type: "bit", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    PictureAlt = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PictureTitle = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KeyWords = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MetaDescription = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "Code", "CreationDate", "Description", "IsInStock", "KeyWords", "MetaDescription", "Name", "Picture", "PictureAlt", "PictureTitle", "Price", "ShortDescription", "Slug" },
                values: new object[] { 1L, "#tes", new DateTime(2022, 11, 13, 16, 40, 8, 775, DateTimeKind.Local).AddTicks(6785), "firsTest", true, "test", "testtest", "TES1", "test.jpg", "tests", "titletest", 2300m, "this is test", "testslug" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");
        }
    }
}
