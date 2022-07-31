using Allup.DAL;
using Allup.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;
        public HeaderViewComponent(AppDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userId = _userManager.GetUserId(Request.HttpContext.User);

            var user =  await _userManager.FindByIdAsync(userId);

            List<Order> orders;

            if (user != null)
            {
                var roles = await _userManager.GetRolesAsync(user);
                orders = _context.Orders.Where(o => o.UserId == userId).ToList();

                ViewBag.CurrentUser = user;
                ViewBag.CurrentUserRoles = roles;
            }
            else
            {
                orders = new List<Order>();

            }


            ViewBag.Cats = _context.Categories.ToList();
            ViewBag.OrderCount = orders.Count;
            Bio bio = _context.Bios.FirstOrDefault();
            return View(await Task.FromResult(bio));
        }
    }
}
