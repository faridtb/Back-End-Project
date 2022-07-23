using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Allup.Migrations
{
    public partial class mig10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 51, 15, 939, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 51, 15, 943, DateTimeKind.Local).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 51, 15, 943, DateTimeKind.Local).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 51, 15, 943, DateTimeKind.Local).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 51, 15, 943, DateTimeKind.Local).AddTicks(3117));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 51, 15, 943, DateTimeKind.Local).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 51, 15, 943, DateTimeKind.Local).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 51, 15, 943, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 51, 15, 943, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 51, 15, 943, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 51, 15, 944, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 51, 15, 944, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 51, 15, 944, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 51, 15, 944, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 51, 15, 944, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 51, 15, 944, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 51, 15, 944, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 51, 15, 944, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 51, 15, 944, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 51, 15, 944, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 51, 15, 944, DateTimeKind.Local).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 51, 15, 944, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 51, 15, 944, DateTimeKind.Local).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "images/category-3.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 51, 15, 944, DateTimeKind.Local).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 51, 15, 944, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 51, 15, 944, DateTimeKind.Local).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 51, 15, 944, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 51, 15, 944, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 51, 15, 944, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 51, 15, 944, DateTimeKind.Local).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 51, 15, 944, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BestSeller", "BrandId", "CategoryId", "CreatedAt", "DeletedAt", "DiscountPrice", "InStock", "IsDeleted", "IsFeatured", "Name", "NewArrival", "Price", "StockCount", "TaxPercent", "UptadetAt" },
                values: new object[] { 9, true, 7, 2, new DateTime(2022, 7, 23, 0, 51, 15, 944, DateTimeKind.Local).AddTicks(9199), null, 0.0, true, false, false, "Macbook Pro3", false, 5000.0, 39, 0.0, null });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageUrl", "IsMain", "ProductId" },
                values: new object[] { 17, "images/category-1.jpg", true, 9 });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageUrl", "IsMain", "ProductId" },
                values: new object[] { 18, "images/category-6.jpg", false, 9 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 14, 58, 563, DateTimeKind.Local).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 14, 58, 565, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 14, 58, 565, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 14, 58, 565, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 14, 58, 565, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 14, 58, 565, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 14, 58, 565, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 14, 58, 565, DateTimeKind.Local).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 14, 58, 565, DateTimeKind.Local).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 14, 58, 565, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 14, 58, 565, DateTimeKind.Local).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 14, 58, 565, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 14, 58, 565, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 14, 58, 565, DateTimeKind.Local).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 14, 58, 565, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 14, 58, 565, DateTimeKind.Local).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 14, 58, 565, DateTimeKind.Local).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 14, 58, 566, DateTimeKind.Local).AddTicks(63));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 14, 58, 566, DateTimeKind.Local).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 14, 58, 566, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 14, 58, 566, DateTimeKind.Local).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 14, 58, 566, DateTimeKind.Local).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 14, 58, 566, DateTimeKind.Local).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "images/product/product-10.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 14, 58, 566, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 14, 58, 566, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 14, 58, 566, DateTimeKind.Local).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 14, 58, 566, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 14, 58, 566, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 14, 58, 566, DateTimeKind.Local).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 14, 58, 566, DateTimeKind.Local).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 14, 58, 566, DateTimeKind.Local).AddTicks(3759));
        }
    }
}
