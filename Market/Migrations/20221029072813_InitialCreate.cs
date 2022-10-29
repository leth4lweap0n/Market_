







using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Market.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CancelledSalesInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnearnedMoney = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CancelledSalesInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConfirmedSalesInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoneyEarned = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfirmedSalesInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Barkod = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Barkod);
                });

            migrationBuilder.CreateTable(
                name: "QuickSaleCommonProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductBarkod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuickSaleCommonProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Barkod = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Permission = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Barkod", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, "Apple", 2, 10 },
                    { 17, "Blueberry", 18, 10 },
                    { 15, "Lime", 16, 10 },
                    { 14, "Lemon", 15, 10 },
                    { 13, "Kiwi", 14, 10 },
                    { 12, "Pomegranate", 13, 10 },
                    { 11, "Mango", 2, 10 },
                    { 10, "Cherry", 1, 10 },
                    { 16, "Raspberry", 17, 10 },
                    { 8, "Pear", 9, 10 },
                    { 7, "Peach", 8, 10 },
                    { 6, "Strawberry", 7, 10 },
                    { 5, "Watermelon", 6, 10 },
                    { 4, "Pineapple", 5, 10 },
                    { 3, "Banana", 4, 10 },
                    { 2, "Orange", 3, 10 },
                    { 9, "Grape", 10, 10 }
                });

            migrationBuilder.InsertData(
                table: "QuickSaleCommonProducts",
                columns: new[] { "Id", "ProductBarkod" },
                values: new object[,]
                {
                    { 13, 13 },
                    { 12, 12 },
                    { 11, 11 },
                    { 10, 10 },
                    { 9, 9 },
                    { 8, 8 },
                    { 4, 4 },
                    { 6, 6 },
                    { 5, 5 },
                    { 3, 3 },
                    { 2, 2 },
                    { 1, 1 },
                    { 14, 14 },
                    { 7, 7 },
                    { 15, 15 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CancelledSalesInfo");

            migrationBuilder.DropTable(
                name: "ConfirmedSalesInfo");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "QuickSaleCommonProducts");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
