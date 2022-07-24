using Allup.DAL;
using Allup.Models;
using Allup.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.ViewComponents
{
    public class BasketViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public BasketViewComponent(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            string basket = Request.Cookies["basket"];
            double totalPrice = 0;
            int totalCount = 0;

            List<BasketVM> products;

            if (basket != null)
            {
                products = JsonConvert.DeserializeObject<List<BasketVM>>(basket);

                foreach (BasketVM item in products)
                {
                    Product product = _context.Products.Include(p => p.ProductImages).FirstOrDefault(p => p.Id == item.Id);
                    item.Price = product.Price;
                    item.Name = product.Name;
                    item.ImgUrl = product.ProductImages.Find(p => p.IsMain == true).ImageUrl;
                    item.SubTotalPrice += product.Price * item.Count;
                    totalPrice += item.SubTotalPrice;
                    totalCount += item.Count;
                }
            }
            else
            {
                products = new List<BasketVM>();
            }
            ViewBag.TotalPrice = totalPrice;
            ViewBag.TotalCount = totalCount;
            return View(await Task.FromResult(products));
        }
    }
}
