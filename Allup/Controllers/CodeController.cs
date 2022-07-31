using BarcodeLib;
using Microsoft.AspNetCore.Mvc;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Controllers
{
    public class CodeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //#region Code Generators
        ////Barcode generator
        //public IActionResult GenerateBarcode(string invoiceNo = "say")
        //{
        //    Barcode barcode = new Barcode();
        //    Image img = barcode.Encode(TYPE.CODE39, invoiceNo, Color.Black, Color.White, 250, 100);
        //    var data = ConvertToImageToBytes(img);
        //    return File(data, "image/jpeg");
        //}

        //private byte[] ConvertToImageToBytes(Image image)
        //{
        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
        //        return ms.ToArray();
        //    }
        //}

        ////QRcode generator


        //public IActionResult GenerateQRcode(string url)
        //{
        //    QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
        //    QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);
        //    QRCode qRCode = new QRCode(qRCodeData);
        //    Bitmap bitmap = qRCode.GetGraphic(15);
        //    var bitmapBytes = ConvertBitmapToBytes(bitmap);
        //    return File(bitmapBytes, "image/jpeg");

        //}

        //public byte[] ConvertBitmapToBytes(Bitmap bitmap)
        //{
        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        bitmap.Save(ms,ImageFormat.Png);
        //        return ms.ToArray();
        //    }
        //}

        //#endregion

        public void QrCodeGenerator(string inputText)
        {

            using (MemoryStream ms = new MemoryStream())
            {
                QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
                QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(inputText, QRCodeGenerator.ECCLevel.Q);
                QRCode qRCode = new QRCode(qRCodeData);
                using (Bitmap bitmap = qRCode.GetGraphic(15))
                {
                    bitmap.Save(ms,ImageFormat.Png);
                    ViewBag.QRCode = "data:image/png;base64,"+Convert.ToBase64String(ms.ToArray());
                }
            }
        }

    }
}
