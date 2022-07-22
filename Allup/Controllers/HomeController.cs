using Allup.DAL;
using Allup.ViewModels;
using Microsoft.AspNetCore.Mvc;
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
