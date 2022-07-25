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
    public class DetailController : Controller
    {
        private readonly AppDbContext _context;
        public DetailController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ShopVM shopVM = new ShopVM();

            Product dbProcduct = _context.Products
                    .Include(p => p.ProductImages)
                    .Include(p => p.Brand)
                    .Include(p => p.Category)
                    .Include(p => p.TagProducts)
                    .FirstOrDefault(p => p.Id == id);

            if (dbProcduct == null) return NotFound();

            shopVM.Product = dbProcduct;
            shopVM.Categories = _context.Categories.ToList();
            shopVM.Reviews = _context.Reviews.ToList();
            shopVM.Products = _context.Products.Include(p => p.ProductImages).Include(p => p.Brand).Include(p => p.Category).ToList();
            shopVM.Brands = _context.Brands.ToList();
            shopVM.Banners = _context.ShippingBanners.ToList();


            return View(shopVM);

        }
    }
}
