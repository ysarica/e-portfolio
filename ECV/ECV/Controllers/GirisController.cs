using ECV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECV.Controllers
{
    public class GirisController : Controller
    {
        // GET: Giris
        eCV db = new eCV();
        [HttpGet]
        public ActionResult Index()
        {
            if (Session["kullanici"] == null)
            {
                return View();
            }
            else
                return Redirect("/Admin/Index");
        }

        [HttpPost]
        public ActionResult Index(string ka, string pw)
        {
            ViewBag.h = "normal";
            Admin k = db.Admin.Where(x => x.ka == ka && x.pw == pw).SingleOrDefault();
            if (k != null)
            {
                Session["kullanici"] = k;
                Session["isim"] = k.pw;
                return RedirectToAction("Index", "Anasayfa");
            }
            else
            {
                ViewBag.h = "hata";

            }
            return View();
        }
        public ActionResult cikis()
        {
            Session.Clear();
            return Redirect("/Giris/Index");
        }
    }
}