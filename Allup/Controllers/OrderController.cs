﻿using Allup.DAL;
using Allup.Extentions;
using Allup.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;
using System.Security.Claims;

namespace Allup.Controllers
{
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _config;
        public OrderController(AppDbContext context, UserManager<User> userManager, IConfiguration config)
        {
            _context = context;
            _userManager = userManager;
            _config = config;
        }


        public IActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            Order order = new Order();

            var basket = _context.Baskets.Include(b => b.BasketItems).ThenInclude(b => b.Product).FirstOrDefault(b => b.UserId == userId);

            ViewBag.BasketItems = basket.BasketItems.ToList();

            return View(order);
        }

        [HttpPost]
        public IActionResult Sale(Order order, string radio = "Cash")
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(String.Empty, "Error has been occured");
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var user = _context.Users.Find(userId);

            var basket = _context.Baskets.Include(b => b.BasketItems).ThenInclude(b => b.Product).FirstOrDefault(b => b.UserId == userId);

            var basketItems = basket.BasketItems.ToList();

            double total = 0;

            foreach (var item in basketItems)
            {
                total += item.Product.Price * item.ProductCount;
            }

            if (user.Balance <= total)
            {
                return RedirectToAction("index", "home");
            }

            user.Balance -= total;

            Order newOrder = new Order();
            Random random = new Random();

            newOrder.Address = order.Address;
            newOrder.City = order.City;
            newOrder.Country = order.Country;
            newOrder.CreatedAt = DateTime.Now;
            newOrder.Email = order.Email;
            newOrder.FirstName = order.FirstName;
            newOrder.Surname = order.Surname;
            newOrder.Phone = order.Phone;
            newOrder.UserId = userId;
            newOrder.OrderStatus = OrderStatus.New;
            newOrder.PaymantMethod = radio;


            _context.Orders.Add(newOrder);
            _context.SaveChanges();

            newOrder.InvoiceNo = random.Next(1, 99).ToString() + newOrder.Id.ToString();

            foreach (var item in basketItems)
            {
                OrderItem newOrderitem = new OrderItem();

                newOrderitem.ProductId = item.ProductId;
                newOrderitem.OrderId = newOrder.Id;
                newOrderitem.ProductCount = item.ProductCount;
                newOrderitem.ProductPrice = item.Product.Price;
                newOrderitem.Total += item.Product.Price * item.ProductCount;
                newOrder.TotalPrice += newOrderitem.Total;

                _context.OrderItems.Add(newOrderitem);
                _context.BasketItems.Remove(item);
            }

            EmailService emailService = new EmailService(_config.GetSection("ConfirmationParams:Email").Value, _config.GetSection("ConfirmationParams:Password").Value);
            var emailResult = emailService.SendEmail(user.Email);


            _context.SaveChanges();
            return RedirectToAction("index", "home");
        }

        public IActionResult Orders()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var orders = _context.Orders.Where(o => o.UserId == userId).ToList();

            return View(orders);
        }

        public IActionResult OrderDetail(int id)
        {
            var order = _context.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(o => o.Product)
                .ThenInclude(o => o.ProductImages)
                .FirstOrDefault(o => o.Id == id);

            return View(order);
        }

        public IActionResult Invoice(int id)
        {
            var order = _context.Orders
                .Include(u => u.User)
               .Include(o => o.OrderItems)
               .ThenInclude(o => o.Product)
               .FirstOrDefault(o => o.Id == id);

            return View(order);
        }

        //[HttpPost]
        //public IActionResult Invoice()
        //{

        //    HtmlToPdfConverter converter = new HtmlToPdfConverter();

        //    WebKitConverterSettings settings = new WebKitConverterSettings();
        //    settings.WebKitPath = Path.Combine(_hosting.ContentRootPath, "QtBinariesWindows");
        //    converter.ConverterSettings = settings;

        //    PdfDocument document = converter.Convert("https://localhost/convert-html-to-pdf/invoice");

        //    MemoryStream ms = new MemoryStream();
        //    document.Save(ms);
        //    document.Close(true);

        //    ms.Position = 0;


        //    FileStreamResult fileStreamResult = new FileStreamResult(ms, "application/pdf");
        //    fileStreamResult.FileDownloadName = $"Invoice.pdf";

        //    return fileStreamResult;
        //    // return View(order);
        //}
    }
}
