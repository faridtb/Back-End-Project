using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Allup.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(nullable: true),
                    SupportContact = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Contact = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    WorkTime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bios", x => x.Id);
                });

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
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    UptadetAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    UptadetAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ParentId = table.Column<int>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    UptadetAt = table.Column<DateTime>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    OrderStatus = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiscountSec = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    UptadetAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Baskets_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    UptadetAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsFeatured = table.Column<bool>(nullable: false),
                    BestSeller = table.Column<bool>(nullable: false),
                    NewArrival = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    InStock = table.Column<bool>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    DiscountPrice = table.Column<double>(nullable: false),
                    TaxPercent = table.Column<double>(nullable: false),
                    StockCount = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    BrandId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TagBlog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogId = table.Column<int>(nullable: false),
                    TagId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagBlog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TagBlog_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagBlog_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BasketItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ProductCount = table.Column<int>(nullable: false),
                    BasketId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasketItems_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    UptadetAt = table.Column<DateTime>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Total = table.Column<double>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(nullable: true),
                    IsMain = table.Column<bool>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderName = table.Column<string>(nullable: true),
                    SenderEmail = table.Column<string>(nullable: true),
                    SendText = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TagProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    TagId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TagProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WishLists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WishLists_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WishLists_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Banners",
                columns: new[] { "Id", "ImageUrl" },
                values: new object[,]
                {
                    { 1, "images/banner-1.png" },
                    { 2, "images/banner-2.png" }
                });

            migrationBuilder.InsertData(
                table: "Bios",
                columns: new[] { "Id", "Contact", "Email", "ImageUrl", "Location", "SupportContact", "WorkTime" },
                values: new object[] { 1, "+994(50)568-38-10", "baliyevfarid@gmail.com", "images/logo.png", "Baku,Nasimi district,4 mkr", "+994(60)666-66-66", "Hefte:1-6 gunler - 09:00 ~ 21:00" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Content", "ImageUrl", "Time", "Title" },
                values: new object[,]
                {
                    { 1, "Insana pul geldikce onu nece mehv etmeyi baresinde maraqli ideyalara sahib olmaga bashlayir..", "images/blog-1.jpg", new DateTime(2022, 7, 28, 21, 33, 22, 597, DateTimeKind.Local).AddTicks(7169), "Bu gun ne alim ?" },
                    { 2, "Insana pul geldi ve onu nece mehv etmeyi baresinde maraqli ideyalara sahib olmaga bashladi...", "images/blog-2.jpg", new DateTime(2022, 7, 28, 21, 33, 22, 597, DateTimeKind.Local).AddTicks(7757), "Dunen ne aldim ?" },
                    { 3, "Insana pul gelerse onu nece mehv etmeyi baresinde maraqli ideyalara sahib olmaga bashlayacaq..", "images/blog-3.jpg", new DateTime(2022, 7, 28, 21, 33, 22, 597, DateTimeKind.Local).AddTicks(7796), "Sabah ne alim ?" },
                    { 4, "ARtiq blog ve onun contenti....", "images/blog-4.jpg", new DateTime(2022, 7, 28, 21, 33, 22, 597, DateTimeKind.Local).AddTicks(7817), "Bu umumiyyetle artiq blogdur evvelkilere baxin" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ImageUrl", "IsDeleted", "Name", "UptadetAt" },
                values: new object[,]
                {
                    { 10, new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(2116), null, "images/brand/brand-3.jpg", false, "Logitech", null },
                    { 9, new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(2095), null, "images/brand/brand-4.jpg", false, "Pegasus", null },
                    { 8, new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(2076), null, "images/brand/brand-2.jpg", false, "Gucci", null },
                    { 7, new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(2056), null, "images/brand/brand-1.jpg", false, "Apple", null },
                    { 6, new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(2036), null, "images/brand/brand-6.jpg", false, "Xiaomi", null },
                    { 4, new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(1990), null, "images/brand/brand-4.jpg", false, "Philips", null },
                    { 3, new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(1967), null, "images/brand/brand-3.jpg", false, "Asus", null },
                    { 2, new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(1820), null, "images/brand/brand-2.jpg", false, "Samsung", null },
                    { 1, new DateTime(2022, 7, 28, 21, 33, 22, 594, DateTimeKind.Local).AddTicks(3391), null, "images/brand/brand-1.jpg", false, "Adidas", null },
                    { 5, new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(2011), null, "images/brand/brand-5.jpg", false, "Sony", null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ImageUrl", "IsDeleted", "Name", "ParentId", "UptadetAt" },
                values: new object[,]
                {
                    { 9, new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(7481), null, "images/category-9.jpg", false, "Household", null, null },
                    { 13, new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(7564), null, "images/category-1.jpg", false, "Technologics", null, null },
                    { 10, new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(7503), null, "images/category-8.jpg", false, "Accessories", null, null },
                    { 7, new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(7428), null, "images/category-7.jpg", false, "Audio & Video", null, null },
                    { 1, new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(7258), null, "images/category-2.jpg", false, "Computer", null, null },
                    { 5, new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(7383), null, "images/category-5.jpg", false, "Bottoms", null, null },
                    { 4, new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(7360), null, "images/category-4.jpg", false, "Game Consoles", null, null },
                    { 3, new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(7286), null, "images/category-3.jpg", false, "Smartphone", null, null },
                    { 6, new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(7407), null, "images/category-6.jpg", false, "Tops & Sets", null, null }
                });

            migrationBuilder.InsertData(
                table: "ShippingBanners",
                columns: new[] { "Id", "Desc", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 1, "Gotur Apar", "images/banner-icon/icon1.png", "Pulsuz Dasinmaa" },
                    { 2, "Hefte ici her axsam", "images/banner-icon/icon2.png", "Ideal Dasinmaa" },
                    { 3, "Hefte sonu her seher", "images/banner-icon/icon3.png", "LIMAK KARGO LTD" },
                    { 4, "7/24 en bahali ve en keyfiyyetli dasinma biz beleyik ! ve bundan sonrada beledi belediki !", "images/banner-icon/icon4.png", "BALIYEV KARGOS" }
                });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "Desc", "DiscountSec", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 1, "Explore and immerse in exciting 360 content with Fulldive’s all-in-one virtual reality platform", "Save $666 when you buy", "images/slider-1.jpg", "2079 Virtual Reality" },
                    { 2, "Etceken masindan istifade etmekle siz, qessabdan aldiginiz iri tikeleri rahatliqla qiyme halina cevirib dadli kotletler hazirlaya bilersiniz !", "Mohtesem Companiyyaa Shok shok !!!", "images/slider-2.jpg", "Et ceken masinnnnn" }
                });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "AuthorEmail", "AuthorName", "Content", "ImageUrl" },
                values: new object[,]
                {
                    { 2, "nakata@mail.ru", "Takashi", "Vurdun insanlari bir birine", "images/author-2.jpg" },
                    { 1, "farid@baliyev.com", "Farid", "Cagir ginen dost tanisivi otursun seniynen", "images/author-1.png" },
                    { 3, "hiri@mail.ru", "Hiroshi", "Bomba kimidi havalar", "images/author-3.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ImageUrl", "IsDeleted", "Name", "ParentId", "UptadetAt" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(7029), null, "images/category-1.jpg", false, "Laptop", 1, null },
                    { 12, new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(7544), null, "images/category-12.jpg", false, "Video Games", 4, null },
                    { 8, new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(7459), null, "images/category-10.jpg", false, "Camera", 7, null },
                    { 11, new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(7523), null, "images/category-11.jpg", false, "Michrophone", 7, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BestSeller", "BrandId", "CategoryId", "CreatedAt", "DeletedAt", "DiscountPrice", "InStock", "IsDeleted", "IsFeatured", "Name", "NewArrival", "Price", "StockCount", "TaxPercent", "UptadetAt" },
                values: new object[,]
                {
                    { 8, false, 6, 3, new DateTime(2022, 7, 28, 21, 33, 22, 597, DateTimeKind.Local).AddTicks(1459), null, 0.0, true, false, true, "Xiaomi mi9t", true, 900.0, 75, 0.0, null },
                    { 1, false, 10, 4, new DateTime(2022, 7, 28, 21, 33, 22, 596, DateTimeKind.Local).AddTicks(8041), null, 30.0, true, false, false, "Joystic Logitech g66", true, 900.0, 33, 0.0, null },
                    { 4, true, 2, 7, new DateTime(2022, 7, 28, 21, 33, 22, 597, DateTimeKind.Local).AddTicks(1366), null, 0.0, true, false, false, "Printer (Samsung Yta-55)", true, 300.0, 25, 0.0, null },
                    { 2, true, 5, 10, new DateTime(2022, 7, 28, 21, 33, 22, 597, DateTimeKind.Local).AddTicks(1152), null, 30.0, true, false, false, "Qulaqliqs", false, 250.0, 30, 0.0, null },
                    { 3, false, 4, 10, new DateTime(2022, 7, 28, 21, 33, 22, 597, DateTimeKind.Local).AddTicks(1341), null, 0.0, true, false, true, "Flashcard", false, 75.0, 25, 0.0, null },
                    { 6, true, 1, 10, new DateTime(2022, 7, 28, 21, 33, 22, 597, DateTimeKind.Local).AddTicks(1414), null, 0.0, true, false, true, "Sunglasses", false, 99.0, 800, 0.0, null },
                    { 5, false, 2, 13, new DateTime(2022, 7, 28, 21, 33, 22, 597, DateTimeKind.Local).AddTicks(1388), null, 0.0, true, false, true, "Drone", true, 3000.0, 9, 0.0, null },
                    { 7, false, 3, 13, new DateTime(2022, 7, 28, 21, 33, 22, 597, DateTimeKind.Local).AddTicks(1437), null, 0.0, true, false, true, "PhotoAparatte", false, 199.0, 75, 0.0, null }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageUrl", "IsMain", "ProductId" },
                values: new object[,]
                {
                    { 6, "images/product/product-6.jpg", false, 2 },
                    { 8, "images/product/product-15.jpg", false, 5 },
                    { 7, "images/product/product-14.jpg", true, 5 },
                    { 12, "images/product/product-12.jpg", false, 6 },
                    { 11, "images/product/product-13.jpg", true, 6 },
                    { 10, "images/product/product-7.jpg", false, 3 },
                    { 9, "images/product/product-8.jpg", true, 3 },
                    { 13, "images/product/product-10.jpg", true, 7 },
                    { 14, "images/product/product-11.jpg", false, 7 },
                    { 4, "images/product/product-2.jpg", false, 4 },
                    { 3, "images/product/product-1.jpg", true, 4 },
                    { 2, "images/product/product-9.jpg", false, 1 },
                    { 1, "images/product/product-3.jpg", true, 1 },
                    { 16, "images/product/product-11.jpg", false, 8 },
                    { 15, "images/category-3.jpg", true, 8 },
                    { 5, "images/product/product-5.jpg", true, 2 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BestSeller", "BrandId", "CategoryId", "CreatedAt", "DeletedAt", "DiscountPrice", "InStock", "IsDeleted", "IsFeatured", "Name", "NewArrival", "Price", "StockCount", "TaxPercent", "UptadetAt" },
                values: new object[] { 9, true, 7, 2, new DateTime(2022, 7, 28, 21, 33, 22, 597, DateTimeKind.Local).AddTicks(1536), null, 0.0, true, false, false, "Macbook Pro3", false, 5000.0, 39, 0.0, null });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageUrl", "IsMain", "ProductId" },
                values: new object[] { 17, "images/category-1.jpg", true, 9 });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageUrl", "IsMain", "ProductId" },
                values: new object[] { 18, "images/category-6.jpg", false, 9 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_BasketId",
                table: "BasketItems",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_ProductId",
                table: "BasketItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_UserId",
                table: "Baskets",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentId",
                table: "Categories",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProductId",
                table: "Comments",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TagBlog_BlogId",
                table: "TagBlog",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_TagBlog_TagId",
                table: "TagBlog",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_TagProducts_ProductId",
                table: "TagProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_WishLists_ProductId",
                table: "WishLists",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_WishLists_UserId",
                table: "WishLists",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.DropTable(
                name: "BasketItems");

            migrationBuilder.DropTable(
                name: "Bios");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "ShippingBanners");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "TagBlog");

            migrationBuilder.DropTable(
                name: "TagProducts");

            migrationBuilder.DropTable(
                name: "Testimonials");

            migrationBuilder.DropTable(
                name: "WishLists");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
