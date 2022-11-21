using ECV.Models;
using ECV.Models.Arac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECV.Controllers
{

    [UserAuthorize]

    public class HizmetController : Controller
    {
        eCV db = new eCV();
        // GET: Hizmet
        public PartialViewResult _Liste()
        {

            return PartialView(db.Hizmetler.ToList());
        }
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(Hizmetler h)
        {
            db.Hizmetler.Add(h);
            db.SaveChanges();
            return View();
        }
        public ActionResult Sil(int HID)
        {
            Hizmetler h = db.Hizmetler.Where(x => x.HID == HID).SingleOrDefault();
            db.Hizmetler.Remove(h);
            db.SaveChanges();
            return Redirect("/Hizmet/Ekle");
        }
        public ActionResult Duzenle(int HID)
        {
            return View(db.Hizmetler.Where(x=> x.HID==HID).SingleOrDefault());
        }
        [HttpPost]
        public ActionResult Duzenle(Hizmetler h,int HID)
        {
            Hizmetler hk = db.Hizmetler.Where(x=> x.HID==HID).SingleOrDefault();
            hk.icon = h.icon;
            hk.baslik = h.baslik;
            hk.aciklama = h.aciklama;
            db.SaveChanges();
            return Redirect("/Hizmet/Ekle");
        }
    }
}