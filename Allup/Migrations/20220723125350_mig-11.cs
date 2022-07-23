using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Allup.Migrations
{
    public partial class mig11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Brands",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2022, 7, 23, 16, 53, 49, 623, DateTimeKind.Local).AddTicks(6790), "image/brand/brand-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2022, 7, 23, 16, 53, 49, 630, DateTimeKind.Local).AddTicks(3712), "image/brand/brand-2.jpg" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2022, 7, 23, 16, 53, 49, 630, DateTimeKind.Local).AddTicks(4423), "image/brand/brand-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2022, 7, 23, 16, 53, 49, 630, DateTimeKind.Local).AddTicks(4489), "image/brand/brand-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2022, 7, 23, 16, 53, 49, 630, DateTimeKind.Local).AddTicks(4545), "image/brand/brand-5.jpg" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2022, 7, 23, 16, 53, 49, 630, DateTimeKind.Local).AddTicks(4643), "image/brand/brand-6.jpg" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2022, 7, 23, 16, 53, 49, 630, DateTimeKind.Local).AddTicks(4691), "image/brand/brand-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2022, 7, 23, 16, 53, 49, 630, DateTimeKind.Local).AddTicks(4736), "image/brand/brand-2.jpg" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2022, 7, 23, 16, 53, 49, 630, DateTimeKind.Local).AddTicks(5368), "image/brand/brand-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2022, 7, 23, 16, 53, 49, 630, DateTimeKind.Local).AddTicks(5429), "image/brand/brand-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 16, 53, 49, 632, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 16, 53, 49, 632, DateTimeKind.Local).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 16, 53, 49, 632, DateTimeKind.Local).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 16, 53, 49, 632, DateTimeKind.Local).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 16, 53, 49, 632, DateTimeKind.Local).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 16, 53, 49, 632, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 16, 53, 49, 632, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 16, 53, 49, 632, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 16, 53, 49, 632, DateTimeKind.Local).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 16, 53, 49, 632, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 16, 53, 49, 632, DateTimeKind.Local).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 16, 53, 49, 632, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 16, 53, 49, 632, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 16, 53, 49, 632, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 16, 53, 49, 633, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 16, 53, 49, 633, DateTimeKind.Local).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 16, 53, 49, 633, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 16, 53, 49, 633, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 16, 53, 49, 633, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 16, 53, 49, 633, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 16, 53, 49, 633, DateTimeKind.Local).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 16, 53, 49, 633, DateTimeKind.Local).AddTicks(9236));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Brands");

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 0, 51, 15, 944, DateTimeKind.Local).AddTicks(9199));
        }
    }
}
