using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Allup.Migrations
{
    public partial class mig13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorName = table.Column<string>(nullable: true),
                    AuthorEmail = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 532, DateTimeKind.Local).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 532, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 532, DateTimeKind.Local).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 532, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 525, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 529, DateTimeKind.Local).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 529, DateTimeKind.Local).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 529, DateTimeKind.Local).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 529, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 529, DateTimeKind.Local).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 529, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 529, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 529, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 529, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 530, DateTimeKind.Local).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 530, DateTimeKind.Local).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 530, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 530, DateTimeKind.Local).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 530, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 530, DateTimeKind.Local).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 530, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 530, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 530, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 530, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 530, DateTimeKind.Local).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 530, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 530, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 530, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 531, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 531, DateTimeKind.Local).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 531, DateTimeKind.Local).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 531, DateTimeKind.Local).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 531, DateTimeKind.Local).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 531, DateTimeKind.Local).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 531, DateTimeKind.Local).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 40, 19, 531, DateTimeKind.Local).AddTicks(3256));

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "AuthorEmail", "AuthorName", "Content", "ImageUrl" },
                values: new object[,]
                {
                    { 3, "hiri@mail.ru", "Hiroshi", "Bomba kimidi havalar", "images/author-3.png" },
                    { 2, "nakata@mail.ru", "Takashi", "Vurdun insanlari bir birine", "images/author-2.png" },
                    { 1, "farid@baliyev.com", "Farid", "Cagir ginen dost tanisivi otursun seniynen", "images/author-1.png" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Testimonials");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 532, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 532, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 532, DateTimeKind.Local).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 532, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 523, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 528, DateTimeKind.Local).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 528, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 528, DateTimeKind.Local).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 528, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 528, DateTimeKind.Local).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 528, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 528, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 528, DateTimeKind.Local).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 23, 17, 24, 55, 528, DateTimeKind.Local).AddTicks(6667));

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
        }
    }
}
