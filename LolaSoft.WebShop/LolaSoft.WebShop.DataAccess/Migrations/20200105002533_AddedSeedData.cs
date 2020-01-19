using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LolaSoft.WebShop.DataAccess.Migrations
{
    public partial class AddedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ParentCategoryId" },
                values: new object[] { 1, "Clothes", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ParentCategoryId" },
                values: new object[] { 2, "Pet", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ParentCategoryId" },
                values: new object[] { 3, "House", null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 1, 5, 1, 25, 33, 1, DateTimeKind.Local), "Jacket", 12.2m, 42 },
                    { 2, 1, new DateTime(2020, 1, 5, 1, 25, 33, 4, DateTimeKind.Local), "Shirt", 10.2m, 11 },
                    { 3, 1, new DateTime(2020, 1, 5, 1, 25, 33, 4, DateTimeKind.Local), "Sweater", 25.2m, 35 },
                    { 4, 2, new DateTime(2020, 1, 5, 1, 25, 33, 4, DateTimeKind.Local), "Dog Toy", 3.2m, 18 },
                    { 5, 2, new DateTime(2020, 1, 5, 1, 25, 33, 4, DateTimeKind.Local), "Bowl", 1.2m, 15 },
                    { 6, 3, new DateTime(2020, 1, 5, 1, 25, 33, 4, DateTimeKind.Local), "Fork", 2.2m, 25 },
                    { 7, 3, new DateTime(2020, 1, 5, 1, 25, 33, 4, DateTimeKind.Local), "wash mashine", 122.5m, 41 },
                    { 8, 3, new DateTime(2020, 1, 5, 1, 25, 33, 4, DateTimeKind.Local), "knife", 1.5m, 30 },
                    { 9, 3, new DateTime(2020, 1, 5, 1, 25, 33, 4, DateTimeKind.Local), "spoon", 1.4m, 38 },
                    { 10, 3, new DateTime(2020, 1, 5, 1, 25, 33, 4, DateTimeKind.Local), "dinner table", 65.5m, 47 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
