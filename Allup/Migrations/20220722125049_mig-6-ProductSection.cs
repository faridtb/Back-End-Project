using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Allup.Migrations
{
    public partial class mig6ProductSection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 22, 16, 50, 48, 593, DateTimeKind.Local).AddTicks(6328));

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsDeleted", "Name", "UptadetAt" },
                values: new object[,]
                {
                    { 10, new DateTime(2022, 7, 22, 16, 50, 48, 602, DateTimeKind.Local).AddTicks(4043), null, false, "Logitech", null },
                    { 9, new DateTime(2022, 7, 22, 16, 50, 48, 602, DateTimeKind.Local).AddTicks(3607), null, false, "Pegasus", null },
                    { 8, new DateTime(2022, 7, 22, 16, 50, 48, 602, DateTimeKind.Local).AddTicks(3549), null, false, "Gucci", null },
                    { 7, new DateTime(2022, 7, 22, 16, 50, 48, 602, DateTimeKind.Local).AddTicks(3501), null, false, "Apple", null },
                    { 2, new DateTime(2022, 7, 22, 16, 50, 48, 602, DateTimeKind.Local).AddTicks(2391), null, false, "Samsung", null },
                    { 5, new DateTime(2022, 7, 22, 16, 50, 48, 602, DateTimeKind.Local).AddTicks(3355), null, false, "Sony", null },
                    { 4, new DateTime(2022, 7, 22, 16, 50, 48, 602, DateTimeKind.Local).AddTicks(3291), null, false, "Philips", null },
                    { 3, new DateTime(2022, 7, 22, 16, 50, 48, 602, DateTimeKind.Local).AddTicks(3230), null, false, "Asus", null },
                    { 6, new DateTime(2022, 7, 22, 16, 50, 48, 602, DateTimeKind.Local).AddTicks(3456), null, false, "Xiaomi", null }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 22, 16, 50, 48, 605, DateTimeKind.Local).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 22, 16, 50, 48, 605, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 22, 16, 50, 48, 605, DateTimeKind.Local).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 22, 16, 50, 48, 605, DateTimeKind.Local).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 22, 16, 50, 48, 605, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 22, 16, 50, 48, 605, DateTimeKind.Local).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 22, 16, 50, 48, 605, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 22, 16, 50, 48, 605, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 22, 16, 50, 48, 605, DateTimeKind.Local).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 22, 16, 50, 48, 605, DateTimeKind.Local).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 22, 16, 50, 48, 605, DateTimeKind.Local).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 22, 16, 50, 48, 605, DateTimeKind.Local).AddTicks(4103));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ImageUrl", "IsDeleted", "Name", "ParentId", "UptadetAt" },
                values: new object[] { 13, new DateTime(2022, 7, 22, 16, 50, 48, 605, DateTimeKind.Local).AddTicks(4140), null, "images/category-1.jpg", false, "Technologics", null, null });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageUrl", "IsMain", "ProductId" },
                values: new object[,]
                {
                    { 12, "images/product/product-11.jpg", false, 7 },
                    { 11, "images/product/product-10.jpg", true, 7 },
                    { 10, "images/product/product-13.jpg", true, 6 },
                    { 7, "images/product/product-14.jpg", true, 5 },
                    { 8, "images/product/product-15.jpg", false, 5 },
                    { 6, "images/product/product-6.jpg", false, 2 },
                    { 5, "images/product/product-5.jpg", true, 2 },
                    { 3, "images/product/product-1.jpg", true, 4 },
                    { 2, "images/product/product-9.jpg", false, 1 },
                    { 1, "images/product/product-3.jpg", true, 1 },
                    { 9, "images/product/product-8.jpg", true, 3 },
                    { 4, "images/product/product-2.jpg", false, 4 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BestSeller", "BrandId", "CategoryId", "CreatedAt", "DeletedAt", "DiscountPrice", "InStock", "IsDeleted", "IsFeatured", "Name", "NewArrival", "Price", "StockCount", "TaxPercent", "UptadetAt" },
                values: new object[,]
                {
                    { 7, false, 3, 13, new DateTime(2022, 7, 22, 16, 50, 48, 606, DateTimeKind.Local).AddTicks(8321), null, 0.0, true, false, true, "PhotoAparatte", false, 199.0, 75, 0.0, null },
                    { 6, true, 1, 10, new DateTime(2022, 7, 22, 16, 50, 48, 606, DateTimeKind.Local).AddTicks(8276), null, 0.0, true, false, true, "Sunglasses", false, 99.0, 800, 0.0, null },
                    { 5, false, 2, 13, new DateTime(2022, 7, 22, 16, 50, 48, 606, DateTimeKind.Local).AddTicks(8205), null, 0.0, true, false, true, "Drone", true, 3000.0, 9, 0.0, null },
                    { 4, true, 2, 7, new DateTime(2022, 7, 22, 16, 50, 48, 606, DateTimeKind.Local).AddTicks(8155), null, 0.0, true, false, false, "Printer (Samsung Yta-55)", true, 300.0, 25, 0.0, null },
                    { 3, false, 4, 10, new DateTime(2022, 7, 22, 16, 50, 48, 606, DateTimeKind.Local).AddTicks(8095), null, 0.0, true, false, true, "Flashcard", false, 75.0, 25, 0.0, null },
                    { 2, true, 5, 10, new DateTime(2022, 7, 22, 16, 50, 48, 606, DateTimeKind.Local).AddTicks(6837), null, 0.0, true, false, false, "Qulaqliqs", false, 250.0, 30, 0.0, null },
                    { 1, false, 10, 4, new DateTime(2022, 7, 22, 16, 50, 48, 605, DateTimeKind.Local).AddTicks(5707), null, 0.0, true, false, false, "Joystic Logitech g66", true, 900.0, 33, 0.0, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12);

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

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 22, 15, 38, 8, 768, DateTimeKind.Local).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: null);
        }
    }
}
