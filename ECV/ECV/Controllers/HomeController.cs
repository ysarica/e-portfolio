using ECV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECV.Controllers
{
    public class HomeController : Controller
    {
        eCV db = new eCV();
        // GET: Home
        public ActionResult Index()
        {
            Hakkimda a = db.Hakkimda.Where(x => x.HID == 1).FirstOrDefault();
            ViewBag.ad = a.adSoyad;
            ViewBag.hakkimda = db.Hakkimda.Where(x => x.HID == 1).ToList();
            ViewBag.hizmetler = db.Hizmetler.ToList();
            ViewBag.sosyal = db.Sosyal.ToList();
            ViewBag.yorum = db.Yorum.ToList();
            ViewBag.hobi = db.Hobiler.ToList();
            ViewBag.egitim = db.EgitimBilgi.ToList();
            ViewBag.deneyim = db.Deneyim.ToList();
            ViewBag.beceri = db.Yetenekler.ToList();
            ViewBag.surec = db.Surec.ToList();
            ViewBag.pkategori = db.PortfoyKategori.ToList();
            ViewBag.port = db.Portfoy.ToList();

            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index(GelenMesaj m)
        {
            m.tarih = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString();
            db.GelenMesaj.Add(m);
            db.SaveChanges();
            return Redirect("/Home/Bilgi?bilgi=" + m.adSoyad);
        }

        public ActionResult Bilgi(string bilgi)
        {
            ViewBag.mad = bilgi;
            return View();
        }
        public ActionResult Blog(string kategoriAd)
        {
            ViewBag.blogr = db.blog.ToList();
            ViewBag.sosyal = db.Sosyal.ToList();
            Hakkimda a = db.Hakkimda.Where(x => x.HID == 1).FirstOrDefault();
            ViewBag.ad = a.adSoyad;
            if (kategoriAd == "0")
            {
                ViewBag.blog = db.blog.ToList();

            }
            else
            {
                ViewBag.blog = db.blog.Where(x => x.kategoriAd == kategoriAd).ToList();
            }
            ViewBag.blogkategori = db.blogKategori.ToList();
            return View();


        }
        public ActionResult BlogDetay(string baslik)
        {
            Hakkimda a = db.Hakkimda.Where(x => x.HID == 1).FirstOrDefault();
            ViewBag.ad = a.adSoyad;
            ViewBag.blogdetay = db.blog.Where(x=> x.baslik==baslik).ToList();
            ViewBag.sosyal = db.Sosyal.ToList();
            ViewBag.blogkategori = db.blogKategori.ToList();
            ViewBag.blogr = db.blog.ToList();

            return View();
        }
        public ActionResult Portfolio(int PID)
        {
            ViewBag.sosyal = db.Sosyal.ToList();
            Hakkimda a = db.Hakkimda.Where(x => x.HID == 1).FirstOrDefault();
            ViewBag.ad = a.adSoyad;
            ViewBag.port = db.Portfoy.Where(x=> x.PID==PID).ToList();

            return View();
        }
        public PartialViewResult _Meta()
        {

            return PartialView(db.SiteAyar.Where(x=>x.ID==1).SingleOrDefault());
        }
        public PartialViewResult _Baslik()
        {
            return PartialView(db.SiteAyar.Where(x => x.ID == 1).SingleOrDefault());
        }
        public PartialViewResult _PResim()
        {
            return PartialView(db.Hakkimda.Where(x=> x.HID==1).SingleOrDefault());
        }
    }
}