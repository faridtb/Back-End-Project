using Allup.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagProduct> TagProducts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Bio> Bios { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Banner> Banners { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<Brand>().HasData(
                new Brand
                {
                    Id = 1,
                    Name = "Adidas",
                    CreatedAt = DateTime.Now,
                });



            builder.Entity<Slider>().HasData(
                new Slider
                {
                    Id = 1,
                    Title = "2079 Virtual Reality",
                    DiscountSec = "Save $666 when you buy",
                    Desc = "Explore and immerse in exciting 360 content with Fulldive’s all-in-one virtual reality platform",
                    ImageUrl = "images/slider-1.jpg",
                });

            builder.Entity<Slider>().HasData(
                new Slider
                {
                    Id = 2,
                    Title = "Et ceken masinnnnn",
                    DiscountSec = "Mohtesem Companiyyaa Shok shok !!!",
                    Desc = "Etceken masindan istifade etmekle siz, qessabdan aldiginiz iri tikeleri rahatliqla qiyme halina cevirib dadli kotletler hazirlaya bilersiniz !",
                    ImageUrl = "images/slider-2.jpg",
                });

            builder.Entity<Banner>().HasData(
               new Banner
               {
                   Id = 1,
                   ImageUrl = "images/banner-1.png",
               });

            builder.Entity<Banner>().HasData(
               new Banner
               {
                   Id = 2,
                   ImageUrl = "images/banner-2.png",
               });
        }
    }
}
