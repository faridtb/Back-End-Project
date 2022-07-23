﻿// <auto-generated />
using System;
using Allup.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Allup.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220722201459_mig-9-newProducts")]
    partial class mig9newProducts
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Allup.Models.Banner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Banners");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "images/banner-1.png"
                        },
                        new
                        {
                            Id = 2,
                            ImageUrl = "images/banner-2.png"
                        });
                });

            modelBuilder.Entity("Allup.Models.BasketItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BasketItems");
                });

            modelBuilder.Entity("Allup.Models.Bio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupportContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkTime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bios");
                });

            modelBuilder.Entity("Allup.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UptadetAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2022, 7, 23, 0, 14, 58, 563, DateTimeKind.Local).AddTicks(5452),
                            IsDeleted = false,
                            Name = "Adidas"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2022, 7, 23, 0, 14, 58, 565, DateTimeKind.Local).AddTicks(4494),
                            IsDeleted = false,
                            Name = "Samsung"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2022, 7, 23, 0, 14, 58, 565, DateTimeKind.Local).AddTicks(4626),
                            IsDeleted = false,
                            Name = "Asus"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2022, 7, 23, 0, 14, 58, 565, DateTimeKind.Local).AddTicks(4649),
                            IsDeleted = false,
                            Name = "Philips"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2022, 7, 23, 0, 14, 58, 565, DateTimeKind.Local).AddTicks(4667),
                            IsDeleted = false,
                            Name = "Sony"
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2022, 7, 23, 0, 14, 58, 565, DateTimeKind.Local).AddTicks(4690),
                            IsDeleted = false,
                            Name = "Xiaomi"
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2022, 7, 23, 0, 14, 58, 565, DateTimeKind.Local).AddTicks(4707),
                            IsDeleted = false,
                            Name = "Apple"
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2022, 7, 23, 0, 14, 58, 565, DateTimeKind.Local).AddTicks(4725),
                            IsDeleted = false,
                            Name = "Gucci"
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2022, 7, 23, 0, 14, 58, 565, DateTimeKind.Local).AddTicks(4743),
                            IsDeleted = false,
                            Name = "Pegasus"
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2022, 7, 23, 0, 14, 58, 565, DateTimeKind.Local).AddTicks(4762),
                            IsDeleted = false,
                            Name = "Logitech"
                        });
                });

            modelBuilder.Entity("Allup.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UptadetAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2022, 7, 23, 0, 14, 58, 565, DateTimeKind.Local).AddTicks(9650),
                            ImageUrl = "images/category-1.jpg",
                            IsDeleted = false,
                            Name = "Laptop",
                            ParentId = 1
                        },
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2022, 7, 23, 0, 14, 58, 565, DateTimeKind.Local).AddTicks(9874),
                            ImageUrl = "images/category-2.jpg",
                            IsDeleted = false,
                            Name = "Computer"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2022, 7, 23, 0, 14, 58, 565, DateTimeKind.Local).AddTicks(9900),
                            ImageUrl = "images/category-3.jpg",
                            IsDeleted = false,
                            Name = "Smartphone"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2022, 7, 23, 0, 14, 58, 565, DateTimeKind.Local).AddTicks(9921),
                            ImageUrl = "images/category-4.jpg",
                            IsDeleted = false,
                            Name = "Game Consoles"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2022, 7, 23, 0, 14, 58, 565, DateTimeKind.Local).AddTicks(9940),
                            ImageUrl = "images/category-5.jpg",
                            IsDeleted = false,
                            Name = "Bottoms"
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2022, 7, 23, 0, 14, 58, 565, DateTimeKind.Local).AddTicks(9962),
                            ImageUrl = "images/category-6.jpg",
                            IsDeleted = false,
                            Name = "Tops & Sets"
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2022, 7, 23, 0, 14, 58, 565, DateTimeKind.Local).AddTicks(9981),
                            ImageUrl = "images/category-7.jpg",
                            IsDeleted = false,
                            Name = "Audio & Video"
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2022, 7, 23, 0, 14, 58, 566, DateTimeKind.Local).AddTicks(63),
                            ImageUrl = "images/category-10.jpg",
                            IsDeleted = false,
                            Name = "Camera",
                            ParentId = 7
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2022, 7, 23, 0, 14, 58, 566, DateTimeKind.Local).AddTicks(84),
                            ImageUrl = "images/category-9.jpg",
                            IsDeleted = false,
                            Name = "Household"
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2022, 7, 23, 0, 14, 58, 566, DateTimeKind.Local).AddTicks(105),
                            ImageUrl = "images/category-8.jpg",
                            IsDeleted = false,
                            Name = "Accessories"
                        },
                        new
                        {
                            Id = 11,
                            CreatedAt = new DateTime(2022, 7, 23, 0, 14, 58, 566, DateTimeKind.Local).AddTicks(124),
                            ImageUrl = "images/category-11.jpg",
                            IsDeleted = false,
                            Name = "Michrophone",
                            ParentId = 7
                        },
                        new
                        {
                            Id = 12,
                            CreatedAt = new DateTime(2022, 7, 23, 0, 14, 58, 566, DateTimeKind.Local).AddTicks(143),
                            ImageUrl = "images/category-12.jpg",
                            IsDeleted = false,
                            Name = "Video Games",
                            ParentId = 4
                        },
                        new
                        {
                            Id = 13,
                            CreatedAt = new DateTime(2022, 7, 23, 0, 14, 58, 566, DateTimeKind.Local).AddTicks(162),
                            ImageUrl = "images/category-1.jpg",
                            IsDeleted = false,
                            Name = "Technologics"
                        });
                });

            modelBuilder.Entity("Allup.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Allup.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Allup.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("BestSeller")
                        .HasColumnType("bit");

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<double>("DiscountPrice")
                        .HasColumnType("float");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFeatured")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("NewArrival")
                        .HasColumnType("bit");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("StockCount")
                        .HasColumnType("int");

                    b.Property<double>("TaxPercent")
                        .HasColumnType("float");

                    b.Property<DateTime?>("UptadetAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BestSeller = false,
                            BrandId = 10,
                            CategoryId = 4,
                            CreatedAt = new DateTime(2022, 7, 23, 0, 14, 58, 566, DateTimeKind.Local).AddTicks(579),
                            DiscountPrice = 30.0,
                            InStock = true,
                            IsDeleted = false,
                            IsFeatured = false,
                            Name = "Joystic Logitech g66",
                            NewArrival = true,
                            Price = 900.0,
                            StockCount = 33,
                            TaxPercent = 0.0
                        },
                        new
                        {
                            Id = 2,
                            BestSeller = true,
                            BrandId = 5,
                            CategoryId = 10,
                            CreatedAt = new DateTime(2022, 7, 23, 0, 14, 58, 566, DateTimeKind.Local).AddTicks(3500),
                            DiscountPrice = 30.0,
                            InStock = true,
                            IsDeleted = false,
                            IsFeatured = false,
                            Name = "Qulaqliqs",
                            NewArrival = false,
                            Price = 250.0,
                            StockCount = 30,
                            TaxPercent = 0.0
                        },
                        new
                        {
                            Id = 3,
                            BestSeller = false,
                            BrandId = 4,
                            CategoryId = 10,
                            CreatedAt = new DateTime(2022, 7, 23, 0, 14, 58, 566, DateTimeKind.Local).AddTicks(3619),
                            DiscountPrice = 0.0,
                            InStock = true,
                            IsDeleted = false,
                            IsFeatured = true,
                            Name = "Flashcard",
                            NewArrival = false,
                            Price = 75.0,
                            StockCount = 25,
                            TaxPercent = 0.0
                        },
                        new
                        {
                            Id = 4,
                            BestSeller = true,
                            BrandId = 2,
                            CategoryId = 7,
                            CreatedAt = new DateTime(2022, 7, 23, 0, 14, 58, 566, DateTimeKind.Local).AddTicks(3639),
                            DiscountPrice = 0.0,
                            InStock = true,
                            IsDeleted = false,
                            IsFeatured = false,
                            Name = "Printer (Samsung Yta-55)",
                            NewArrival = true,
                            Price = 300.0,
                            StockCount = 25,
                            TaxPercent = 0.0
                        },
                        new
                        {
                            Id = 5,
                            BestSeller = false,
                            BrandId = 2,
                            CategoryId = 13,
                            CreatedAt = new DateTime(2022, 7, 23, 0, 14, 58, 566, DateTimeKind.Local).AddTicks(3659),
                            DiscountPrice = 0.0,
                            InStock = true,
                            IsDeleted = false,
                            IsFeatured = true,
                            Name = "Drone",
                            NewArrival = true,
                            Price = 3000.0,
                            StockCount = 9,
                            TaxPercent = 0.0
                        },
                        new
                        {
                            Id = 6,
                            BestSeller = true,
                            BrandId = 1,
                            CategoryId = 10,
                            CreatedAt = new DateTime(2022, 7, 23, 0, 14, 58, 566, DateTimeKind.Local).AddTicks(3718),
                            DiscountPrice = 0.0,
                            InStock = true,
                            IsDeleted = false,
                            IsFeatured = true,
                            Name = "Sunglasses",
                            NewArrival = false,
                            Price = 99.0,
                            StockCount = 800,
                            TaxPercent = 0.0
                        },
                        new
                        {
                            Id = 7,
                            BestSeller = false,
                            BrandId = 3,
                            CategoryId = 13,
                            CreatedAt = new DateTime(2022, 7, 23, 0, 14, 58, 566, DateTimeKind.Local).AddTicks(3739),
                            DiscountPrice = 0.0,
                            InStock = true,
                            IsDeleted = false,
                            IsFeatured = true,
                            Name = "PhotoAparatte",
                            NewArrival = false,
                            Price = 199.0,
                            StockCount = 75,
                            TaxPercent = 0.0
                        },
                        new
                        {
                            Id = 8,
                            BestSeller = false,
                            BrandId = 6,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2022, 7, 23, 0, 14, 58, 566, DateTimeKind.Local).AddTicks(3759),
                            DiscountPrice = 0.0,
                            InStock = true,
                            IsDeleted = false,
                            IsFeatured = true,
                            Name = "Xiaomi mi9t",
                            NewArrival = true,
                            Price = 900.0,
                            StockCount = 75,
                            TaxPercent = 0.0
                        });
                });

            modelBuilder.Entity("Allup.Models.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMain")
                        .HasColumnType("bit");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "images/product/product-3.jpg",
                            IsMain = true,
                            ProductId = 1
                        },
                        new
                        {
                            Id = 2,
                            ImageUrl = "images/product/product-9.jpg",
                            IsMain = false,
                            ProductId = 1
                        },
                        new
                        {
                            Id = 3,
                            ImageUrl = "images/product/product-1.jpg",
                            IsMain = true,
                            ProductId = 4
                        },
                        new
                        {
                            Id = 4,
                            ImageUrl = "images/product/product-2.jpg",
                            IsMain = false,
                            ProductId = 4
                        },
                        new
                        {
                            Id = 5,
                            ImageUrl = "images/product/product-5.jpg",
                            IsMain = true,
                            ProductId = 2
                        },
                        new
                        {
                            Id = 6,
                            ImageUrl = "images/product/product-6.jpg",
                            IsMain = false,
                            ProductId = 2
                        },
                        new
                        {
                            Id = 7,
                            ImageUrl = "images/product/product-14.jpg",
                            IsMain = true,
                            ProductId = 5
                        },
                        new
                        {
                            Id = 8,
                            ImageUrl = "images/product/product-15.jpg",
                            IsMain = false,
                            ProductId = 5
                        },
                        new
                        {
                            Id = 9,
                            ImageUrl = "images/product/product-8.jpg",
                            IsMain = true,
                            ProductId = 3
                        },
                        new
                        {
                            Id = 10,
                            ImageUrl = "images/product/product-7.jpg",
                            IsMain = false,
                            ProductId = 3
                        },
                        new
                        {
                            Id = 11,
                            ImageUrl = "images/product/product-13.jpg",
                            IsMain = true,
                            ProductId = 6
                        },
                        new
                        {
                            Id = 12,
                            ImageUrl = "images/product/product-12.jpg",
                            IsMain = false,
                            ProductId = 6
                        },
                        new
                        {
                            Id = 13,
                            ImageUrl = "images/product/product-10.jpg",
                            IsMain = true,
                            ProductId = 7
                        },
                        new
                        {
                            Id = 14,
                            ImageUrl = "images/product/product-11.jpg",
                            IsMain = false,
                            ProductId = 7
                        },
                        new
                        {
                            Id = 15,
                            ImageUrl = "images/product/product-10.jpg",
                            IsMain = true,
                            ProductId = 8
                        },
                        new
                        {
                            Id = 16,
                            ImageUrl = "images/product/product-11.jpg",
                            IsMain = false,
                            ProductId = 8
                        });
                });

            modelBuilder.Entity("Allup.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiscountSec")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sliders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Desc = "Explore and immerse in exciting 360 content with Fulldive’s all-in-one virtual reality platform",
                            DiscountSec = "Save $666 when you buy",
                            ImageUrl = "images/slider-1.jpg",
                            Title = "2079 Virtual Reality"
                        },
                        new
                        {
                            Id = 2,
                            Desc = "Etceken masindan istifade etmekle siz, qessabdan aldiginiz iri tikeleri rahatliqla qiyme halina cevirib dadli kotletler hazirlaya bilersiniz !",
                            DiscountSec = "Mohtesem Companiyyaa Shok shok !!!",
                            ImageUrl = "images/slider-2.jpg",
                            Title = "Et ceken masinnnnn"
                        });
                });

            modelBuilder.Entity("Allup.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UptadetAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Allup.Models.TagProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TagProducts");
                });

            modelBuilder.Entity("Allup.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Allup.Models.ProductImage", b =>
                {
                    b.HasOne("Allup.Models.Product", "product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}