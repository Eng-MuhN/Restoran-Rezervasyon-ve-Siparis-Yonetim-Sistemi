using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restoran_Rezervasyon_ve_Siparis_Yonetim_Sistemi.Controllers
{
    public class ReservationController : Controller
    {
        // GET: Reservation
        public ActionResult Index()
        {
            return View();
        }
        // POST: /Reservation/Index (Backend teammate will connect DB here)
        [HttpPost]
        public ActionResult Index(string fullName, string phone, DateTime? date, string time, int? guestCount, string notes)
        {
            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(phone) || date == null || string.IsNullOrWhiteSpace(time) || guestCount == null)
            {
                ViewBag.Error = "Lütfen tüm zorunlu alanları doldurun.";
                return View();
            }

            // TODO: Backend team saves the Reservation to the database
            ViewBag.Success = $"{fullName} adına {date.Value:dd.MM.yyyy} saat {time} için {guestCount} kişilik rezervasyon talebiniz alındı.";
            return View();
        }
    }
}