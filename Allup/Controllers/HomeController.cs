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
            HomeVM home = new HomeVM();

            home.Sliders = _context.Sliders.ToList();
            home.Banners = _context.Banners.ToList();
            home.Categories = _context.Categories.ToList();
            home.Featured = _context.Products.Include(p => p.ProductImages).Where(p => p.IsFeatured == true).ToList();
            home.NewArrivals = _context.Products.Include(p => p.ProductImages).Where(p => p.NewArrival == true).ToList();
            home.BestSellers = _context.Products.Include(p => p.ProductImages).Where(p => p.BestSeller == true).ToList();
            home.DiscountedProducts = _context.Products.Include(p => p.ProductImages).Where(p => p.DiscountPrice>=30).ToList();



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


    }
}
