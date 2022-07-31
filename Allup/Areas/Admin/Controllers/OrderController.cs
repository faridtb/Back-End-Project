using Allup.DAL;
using Allup.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;
        public OrderController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var orders = _context.Orders.ToList();

            return View(orders);
        }

        
        public IActionResult StatusControl(int id, string status = "New")
        {
            Order order = _context.Orders.Find(id);

            
            switch (status)
            {
                case "New":
                    order.OrderStatus = OrderStatus.New;
                    break;
                case "Delivering":
                    order.OrderStatus = OrderStatus.Delivering;
                    break;
                case "Completed":
                    order.OrderStatus = OrderStatus.Completed;
                    break;
                case "Closed":
                    order.OrderStatus = OrderStatus.Closed;
                    break;
                case "Canceled":
                    order.OrderStatus = OrderStatus.Canceled;
                    break;
            }


            _context.SaveChanges();

            return RedirectToAction("index");
        }


        public IActionResult OrderDetails(int id)
        {

            return View();
        }
    }
}
