using Allup.DAL;
using Allup.Extentions;
using Allup.Models;
using BarcodeLib;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using QRCoder;
using SelectPdf;
using System;
using System.Drawing;
using System.Drawing.Imaging;
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


        public IActionResult Index(int? basketId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Users.Find(userId);

            if (user == null) return RedirectToAction("login", "account");

            if (basketId == null) return RedirectToAction("index", "shop");

            var basket = _context.Baskets.Include(b => b.BasketItems).ThenInclude(b => b.Product).FirstOrDefault(b => b.Id == basketId);

            if (basket.TotalPrice * 1.1 > user.Balance)
            {
                return RedirectToAction("index", "home");
            }

            Order order = new Order();

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

            if (user.Balance < basket.TotalPrice)
            {
                return RedirectToAction("index", "home");
            }

            user.Balance -= basket.TotalPrice;

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

                _context.Products.Find(item.ProductId).StockCount -= item.ProductCount;
                _context.OrderItems.Add(newOrderitem);
                _context.BasketItems.Remove(item);
            }     

            basket.TotalPrice = 0;
            _context.SaveChanges();

            EmailService emailService = new EmailService(_config.GetSection("ConfirmationParams:Email").Value, _config.GetSection("ConfirmationParams:Password").Value);

            emailService.SendEmail(user.Email, "invoice-send", $"Customer:{newOrder.FirstName}", SendInvoice(newOrder.Id), $"{newOrder.InvoiceNo}.pdf");

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

            ViewBag.QRCode = QrCodeGenerator($"Invoice No-{order.InvoiceNo}\nCustomer: {order.FirstName}\n{order.Surname}\nTotal Price:{order.TotalPrice}\n" +
                $"Bizi Secdiyiniz Ucun Teshekkurler ,Hormetle FARID BALIYEV - CEO ALLUP");
            return View(order);
        }

        public byte[] SendInvoice(int id)
        {
            var desktopView = new HtmlToPdf();
            desktopView.Options.WebPageWidth = 1024;


            var pdf = desktopView.ConvertUrl($"https://localhost:44362/order/invoice/{id}");
            var pdfBytes = pdf.Save();


            using (var streamWriter = new StreamWriter($@"C:\Users\User\Desktop\Back-End Project\Back-End-Project\Allup\wwwroot\Pdfs\invoice({id}).pdf"))
            {
                streamWriter.BaseStream.WriteAsync(pdfBytes, 0, pdfBytes.Length);
            }


            return pdfBytes;
        }

        public string QrCodeGenerator(string inputText)
        {
            string content = String.Empty;
            using (MemoryStream ms = new MemoryStream())
            {
                QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
                QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(inputText, QRCodeGenerator.ECCLevel.Q);
                QRCode qRCode = new QRCode(qRCodeData);
                using (Bitmap bitmap = qRCode.GetGraphic(15))
                {
                    bitmap.Save(ms, ImageFormat.Png);
                    content = "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());
                }
            }
            return content;
        }

    }
}
