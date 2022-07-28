using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Allup.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "OrderItems");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymantMethod",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductCount",
                table: "OrderItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "ProductPrice",
                table: "OrderItems",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 940, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 940, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 940, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 940, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 936, DateTimeKind.Local).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 938, DateTimeKind.Local).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 938, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 938, DateTimeKind.Local).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 938, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 938, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 938, DateTimeKind.Local).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 938, DateTimeKind.Local).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 938, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 938, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 939, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 939, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 939, DateTimeKind.Local).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 939, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 939, DateTimeKind.Local).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 939, DateTimeKind.Local).AddTicks(2449));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 939, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 939, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 939, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 939, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 939, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 939, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 939, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 939, DateTimeKind.Local).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 939, DateTimeKind.Local).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 939, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 939, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 939, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 939, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 939, DateTimeKind.Local).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 939, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 29, 1, 51, 51, 939, DateTimeKind.Local).AddTicks(6704));

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UptadetAt" },
                values: new object[,]
                {
                    { 9, new DateTime(2022, 7, 29, 1, 51, 51, 940, DateTimeKind.Local).AddTicks(7620), null, "best", null },
                    { 8, new DateTime(2022, 7, 29, 1, 51, 51, 940, DateTimeKind.Local).AddTicks(7602), null, "innovation", null },
                    { 7, new DateTime(2022, 7, 29, 1, 51, 51, 940, DateTimeKind.Local).AddTicks(7583), null, "interesting", null },
                    { 6, new DateTime(2022, 7, 29, 1, 51, 51, 940, DateTimeKind.Local).AddTicks(7564), null, "health", null },
                    { 5, new DateTime(2022, 7, 29, 1, 51, 51, 940, DateTimeKind.Local).AddTicks(7542), null, "creativ", null },
                    { 4, new DateTime(2022, 7, 29, 1, 51, 51, 940, DateTimeKind.Local).AddTicks(7523), null, "technology", null },
                    { 3, new DateTime(2022, 7, 29, 1, 51, 51, 940, DateTimeKind.Local).AddTicks(7459), null, "modern", null },
                    { 2, new DateTime(2022, 7, 29, 1, 51, 51, 940, DateTimeKind.Local).AddTicks(7424), null, "classic", null },
                    { 10, new DateTime(2022, 7, 29, 1, 51, 51, 940, DateTimeKind.Local).AddTicks(7641), null, "useful", null },
                    { 1, new DateTime(2022, 7, 29, 1, 51, 51, 940, DateTimeKind.Local).AddTicks(6976), null, "sport", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "City",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PaymantMethod",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ProductCount",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "ProductPrice",
                table: "OrderItems");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 597, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 597, DateTimeKind.Local).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 597, DateTimeKind.Local).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 597, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 594, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 597, DateTimeKind.Local).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 597, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 597, DateTimeKind.Local).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 597, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 597, DateTimeKind.Local).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 597, DateTimeKind.Local).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 597, DateTimeKind.Local).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 28, 21, 33, 22, 597, DateTimeKind.Local).AddTicks(1536));
        }
    }
}
