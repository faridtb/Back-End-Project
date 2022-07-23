using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Allup.Migrations
{
    public partial class mig12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Time = table.Column<DateTime>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShippingBanners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingBanners", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Content", "ImageUrl", "Time", "Title" },
                values: new object[,]
                {
                    { 1, "Insana pul geldikce onu nece mehv etmeyi baresinde maraqli ideyalara sahib olmaga bashlayir..", "images/blog-1.jpg", new DateTime(2022, 7, 23, 17, 24, 55, 532, DateTimeKind.Local).AddTicks(4456), "Bu gun ne alim ?" },
                    { 2, "Insana pul geldi ve onu nece mehv etmeyi baresinde maraqli ideyalara sahib olmaga bashladi...", "images/blog-2.jpg", new DateTime(2022, 7, 23, 17, 24, 55, 532, DateTimeKind.Local).AddTicks(6343), "Dunen ne aldim ?" },
                    { 3, "Insana pul gelerse onu nece mehv etmeyi baresinde maraqli ideyalara sahib olmaga bashlayacaq..", "images/blog-3.jpg", new DateTime(2022, 7, 23, 17, 24, 55, 532, DateTimeKind.Local).AddTicks(6438), "Sabah ne alim ?" },
                    { 4, "ARtiq blog ve onun contenti....", "images/blog-4.jpg", new DateTime(2022, 7, 23, 17, 24, 55, 532, DateTimeKind.Local).AddTicks(6488), "Bu umumiyyetle artiq blogdur evvelkilere baxin" }
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2022, 7, 23, 17, 24, 55, 523, DateTimeKind.Local).AddTicks(7047), "images/brand/brand-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2022, 7, 23, 17, 24, 55, 528, DateTimeKind.Local).AddTicks(5876), "images/brand/brand-2.jpg" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2022, 7, 23, 17, 24, 55, 528, DateTimeKind.Local).AddTicks(6304), "images/brand/brand-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2022, 7, 23, 17, 24, 55, 528, DateTimeKind.Local).AddTicks(6362), "images/brand/brand-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2022, 7, 23, 17, 24, 55, 528, DateTimeKind.Local).AddTicks(6411), "images/brand/brand-5.jpg" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2022, 7, 23, 17, 24, 55, 528, DateTimeKind.Local).AddTicks(6474), "images/brand/brand-6.jpg" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2022, 7, 23, 17, 24, 55, 528, DateTimeKind.Local).AddTicks(6523), "images/brand/brand-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2022, 7, 23, 17, 24, 55, 528, DateTimeKind.Local).AddTicks(6571), "images/brand/brand-2.jpg" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2022, 7, 23, 17, 24, 55, 528, DateTimeKind.Local).AddTicks(6616), "images/brand/brand-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2022, 7, 23, 17, 24, 55, 528, DateTimeKind.Local).AddTicks(6667), "images/brand/brand-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 529, DateTimeKind.Local).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 529, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 529, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 529, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 529, DateTimeKind.Local).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 529, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 529, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 529, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 529, DateTimeKind.Local).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 529, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 529, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 529, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 529, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 530, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 530, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 530, DateTimeKind.Local).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 530, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 530, DateTimeKind.Local).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 530, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 530, DateTimeKind.Local).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 530, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 530, DateTimeKind.Local).AddTicks(9336));

            migrationBuilder.InsertData(
                table: "ShippingBanners",
                columns: new[] { "Id", "Desc", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 4, "7/24 en bahali ve en keyfiyyetli dasinma biz beleyik ! ve bundan sonrada beledi belediki !", "images/banner-icon/icon4.png", "BALIYEV KARGOS" },
                    { 3, "Hefte sonu her seher", "images/banner-icon/icon3.png", "LIMAK KARGO LTD" },
                    { 2, "Hefte ici her axsam", "images/banner-icon/icon2.png", "Ideal Dasinmaa" },
                    { 1, "Gotur Apar", "images/banner-icon/icon1.png", "Pulsuz Dasinmaa" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "ShippingBanners");

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
    }
}
