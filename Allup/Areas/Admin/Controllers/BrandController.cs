using Allup.DAL;
using Allup.Extentions;
using Allup.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BrandController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public BrandController(AppDbContext context, IWebHostEnvironment env = null)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            List<Brand> brands = _context.Brands
                .Include(b=>b.Products)
                .ToList();

            return View(brands);
        }
        public IActionResult Create()
        {
            Brand brand = new Brand();
            return View(brand);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Brand brand)
        {
            if (!ModelState.IsValid) return View();

            Brand newBrand = new Brand
            {
                Name = brand.Name,
                CreatedAt = DateTime.Now,
                ImageUrl = "images/" + brand.Image.SaveImage(_env, @"assets\images"),
            };

            _context.Brands.Add(newBrand);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


        public  IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();

            Brand dbBrand =  _context.Brands.Find(id);

            if (dbBrand == null) return NotFound();

            _context.Brands.Remove(dbBrand);

             _context.SaveChanges();

            return RedirectToAction("Index");

        }

        public IActionResult Update(int? id)
        {
            if(id == null) return NotFound();

            Brand dbBrand = _context.Brands.FirstOrDefault(b => b.Id == id);

            if (dbBrand == null) return NotFound();

            return View(dbBrand);
        }
    }
}
