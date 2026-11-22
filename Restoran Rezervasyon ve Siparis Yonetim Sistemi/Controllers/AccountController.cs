using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restoran_Rezervasyon_ve_Siparis_Yonetim_Sistemi.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        // POST: /Account/Login (Backend teammate will connect DB + Session here)
        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                ViewBag.Error = "Lütfen e-posta ve şifre alanlarını doldurun.";
                return View();
            }

            // TODO: Backend team checks User/Admin in DB and redirects
            ViewBag.Error = "Giriş işlemi henüz veritabanına bağlanmadı.";
            return View();
        }
        // GET: /Account/AdminLogin (Yönetici Girişi)
        public ActionResult AdminLogin()
        {
            return View();
        }
        // POST: /Account/AdminLogin
        [HttpPost]
        public ActionResult AdminLogin(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                ViewBag.Error = "Lütfen yönetici e-posta ve şifresini doldurun.";
                return View();
            }

            // TODO: Backend team checks Admin in DB and redirects to Admin Panel
            ViewBag.Error = "Yönetici girişi henüz veritabanına bağlanmadı.";
            return View();
        }
    }
}