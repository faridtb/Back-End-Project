using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Allup.Migrations
{
    public partial class mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Total",
                table: "BasketItems",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 259, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 259, DateTimeKind.Local).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 259, DateTimeKind.Local).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 259, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 253, DateTimeKind.Local).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 256, DateTimeKind.Local).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 256, DateTimeKind.Local).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 256, DateTimeKind.Local).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 256, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 256, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 256, DateTimeKind.Local).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 256, DateTimeKind.Local).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 256, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 256, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 257, DateTimeKind.Local).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 257, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 257, DateTimeKind.Local).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 257, DateTimeKind.Local).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 257, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 257, DateTimeKind.Local).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 257, DateTimeKind.Local).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 257, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 257, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 257, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 257, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 257, DateTimeKind.Local).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 257, DateTimeKind.Local).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 257, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 258, DateTimeKind.Local).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 258, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 258, DateTimeKind.Local).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 258, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 258, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 258, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 258, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 258, DateTimeKind.Local).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 259, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 259, DateTimeKind.Local).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 260, DateTimeKind.Local).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 260, DateTimeKind.Local).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 260, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 260, DateTimeKind.Local).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 260, DateTimeKind.Local).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 260, DateTimeKind.Local).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 260, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 13, 5, 31, 260, DateTimeKind.Local).AddTicks(262));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "BasketItems");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 675, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 675, DateTimeKind.Local).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 675, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 675, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 670, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 673, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 673, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 673, DateTimeKind.Local).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 673, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 673, DateTimeKind.Local).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 673, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 673, DateTimeKind.Local).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 673, DateTimeKind.Local).AddTicks(5372));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 673, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 674, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 674, DateTimeKind.Local).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 674, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 674, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 674, DateTimeKind.Local).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 674, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 674, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 674, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 674, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 674, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 674, DateTimeKind.Local).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 674, DateTimeKind.Local).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 674, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 674, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 674, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 674, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 674, DateTimeKind.Local).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 674, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 674, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 674, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 674, DateTimeKind.Local).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 674, DateTimeKind.Local).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 675, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 675, DateTimeKind.Local).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 675, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 675, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 675, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 675, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 675, DateTimeKind.Local).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 675, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 675, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 2, 55, 5, 675, DateTimeKind.Local).AddTicks(8057));
        }
    }
}
