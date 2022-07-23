using Allup.DAL;
using Allup.Models;
using Allup.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            List<Product> products = _context.Products.Include(p => p.ProductImages).ToList();

            Category computer = _context.Categories.FirstOrDefault(c => c.Id == 1);
            Category smartphone = _context.Categories.FirstOrDefault(c => c.Id == 3);
            Category gameConsole = _context.Categories.FirstOrDefault(c => c.Id == 4);

            List<Category> computers = _context.Categories.Where(c => c.ParentId == computer.Id).ToList();
            List<Category> smartphones = _context.Categories.Where(c => c.ParentId == smartphone.Id).ToList();
            List<Category> gameConsoles = _context.Categories.Where(c => c.ParentId == gameConsole.Id).ToList();

            HomeVM home = new HomeVM();

            if (computers.Count == 0)
            {
                home.Computers = products.Where(p => p.CategoryId == computer.Id).ToList();
            }
            else
            {
                foreach (var item in computers)
                {
                    home.Computers = products.Where(p => p.CategoryId == item.Id).ToList();
                }
            }
           

            if (smartphones.Count == 0)
            {
                home.Smartphones = products.Where(p => p.CategoryId == smartphone.Id).ToList();
            }
            else
            {
                foreach (var item in smartphones)
                {
                    home.Smartphones = products.Where(p => p.CategoryId == item.Id).ToList();
                }
            }
           

            if (smartphones.Count == 0)
            {
                home.GameConsoles = products.Where(p => p.CategoryId == gameConsole.Id).ToList();
            }
            else
            {
                foreach (var item in gameConsoles)
                {
                    home.GameConsoles = products.Where(p => p.CategoryId == item.Id).ToList();
                }
            }
               
           
            home.Sliders = _context.Sliders.ToList();
            home.Banners = _context.Banners.ToList();
            home.Categories = _context.Categories.ToList();
            home.Brands = _context.Brands.ToList();
            home.ShippingBanners = _context.ShippingBanners.ToList();
            home.Blogs = _context.Blogs.ToList();
            home.Testimonials = _context.Testimonials.ToList();
            home.Featured = products.Where(p => p.IsFeatured == true).ToList();
            home.NewArrivals = products.Where(p => p.NewArrival == true).ToList();
            home.BestSellers = products.Where(p => p.BestSeller == true).ToList();
            home.DiscountedProducts = products.Where(p => p.DiscountPrice >= 30).ToList();

            
           

            return View(home);
        }

        public IActionResult Shop()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }




        public void CategorySubChecker(List<Category> categories)
        {
            foreach (var item in categories)
            {
                if (item.ParentId != null)
                {
                    Category category = categories.Find(c => c.Id == item.ParentId);
                    category.Children = new List<Category>();
                    category.Children.Add(item);
                }
            }
        }

    }
}
