using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restoran_Rezervasyon_ve_Siparis_Yonetim_Sistemi.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Cart()
        {
            return View();
        }
        // GET: /Order/Checkout (Sipariş Ver: özet, adres ve ödeme)
        public ActionResult Checkout()
        {
            return View();
        }
        // POST: /Order/Checkout (Siparişi tamamlama)
        [HttpPost]
        public ActionResult Checkout(string fullName, string phone, string address, string orderNote, string paymentMethod)
        {
            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(paymentMethod))
            {
                ViewBag.Error = "Lütfen teslimat bilgilerini ve ödeme yöntemini eksiksiz doldurun.";
                return View();
            }

            // TODO: Backend team saves the Order & OrderItems to DB and clears the cart
            ViewBag.Success = $"Siparişiniz alındı! {fullName} adına ({paymentMethod}) en kısa sürede hazırlanıp adresinize gönderilecektir.";
            return View();
        }
    }
}