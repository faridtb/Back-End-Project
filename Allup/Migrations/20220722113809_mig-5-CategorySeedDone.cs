using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Allup.Migrations
{
    public partial class mig5CategorySeedDone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 22, 15, 38, 8, 768, DateTimeKind.Local).AddTicks(9635));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ImageUrl", "IsDeleted", "Name", "ParentId", "UptadetAt" },
                values: new object[,]
                {
                    { 2, null, null, "images/category-1.jpg", false, "Laptop", 1, null },
                    { 1, null, null, "images/category-2.jpg", false, "Computer", null, null },
                    { 3, null, null, "images/category-3.jpg", false, "Smartphone", null, null },
                    { 4, null, null, "images/category-4.jpg", false, "Game Consoles", null, null },
                    { 5, null, null, "images/category-5.jpg", false, "Bottoms", null, null },
                    { 6, null, null, "images/category-6.jpg", false, "Tops & Sets", null, null },
                    { 7, null, null, "images/category-7.jpg", false, "Audio & Video", null, null },
                    { 8, null, null, "images/category-10.jpg", false, "Camera", 7, null },
                    { 9, null, null, "images/category-9.jpg", false, "Household", null, null },
                    { 10, null, null, "images/category-8.jpg", false, "Accessories", null, null },
                    { 11, null, null, "images/category-11.jpg", false, "Michrophone", 7, null },
                    { 12, null, null, "images/category-12.jpg", false, "Video Games", 4, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 22, 14, 47, 50, 119, DateTimeKind.Local).AddTicks(4625));
        }
    }
}
