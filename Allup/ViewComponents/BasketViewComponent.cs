﻿using Allup.DAL;
using Allup.Models;
using Allup.ViewModels;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<User> _userManager;
        public BasketViewComponent(AppDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {

            var userId = _userManager.GetUserId(Request.HttpContext.User);
            var user = await _userManager.FindByIdAsync(userId);

            Basket basket;

            if (userId == null)
            {
                basket = new Basket();
            }
            else
            {
                basket = _context.Baskets
                .Include(b => b.BasketItems)
                .ThenInclude(b => b.Product)
                .ThenInclude(b => b.ProductImages)
                .FirstOrDefault(b => b.UserId == userId);

                if (basket == null)
                {
                    basket = new Basket() { UserId = userId };
                    basket.BasketItems = new List<BasketItem>();
                    _context.Add(basket);
                    _context.SaveChanges();
                }

            }

            ViewBag.CurrentUser = user;

            return View(await Task.FromResult(basket));
        }
    }
}
