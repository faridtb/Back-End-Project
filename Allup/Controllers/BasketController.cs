using Allup.DAL;
using Allup.Models;
using Allup.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Controllers
{
    public class BasketController : Controller
    {
        private readonly AppDbContext _context;

        public BasketController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddItem(int? id, string ReturnUrl)
        {
            if (id == null) return NoContent();

            Product product = _context.Products.FirstOrDefault(x => x.Id == id);

            if (product == null) return NotFound();

            List<BasketVM> products = GetBasket();

            BasketVM isexsist = products.Find(p => p.Id == id);

            if (isexsist == null)
            {
                BasketVM basketVM = new BasketVM
                {
                    Id = product.Id,
                    Count = 1,
                    Price = product.Price,
                };
                products.Add(basketVM);
            }
            else
            {
                isexsist.Count++;
            }

            Response.Cookies.Append("basket", JsonConvert.SerializeObject(products));

            if (ReturnUrl != null) return Redirect(ReturnUrl);

            return RedirectToAction("index", "shop");
        }

        public IActionResult Remove(int? id, string ReturnUrl)
        {

            List<BasketVM> products = GetBasket();

            if (products == null) return NotFound();

            BasketVM deleteProduct = products.FirstOrDefault(p => p.Id == id);

            products.Remove(deleteProduct);

            Response.Cookies.Append("basket", JsonConvert.SerializeObject(products));

            if (ReturnUrl != null) return Redirect(ReturnUrl);

            return RedirectToAction("index", "shop");
        }

        public List<BasketVM> GetBasket()
        {
            string basket = Request.Cookies["basket"];

            List<BasketVM> products = basket != null ? JsonConvert.DeserializeObject<List<BasketVM>>(basket)
                : new List<BasketVM>();

            return products;
        }

    }
}
