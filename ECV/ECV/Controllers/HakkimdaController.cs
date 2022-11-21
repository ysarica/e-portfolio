using ECV.Models;
using ECV.Models.Arac;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECV.Controllers
{
    [UserAuthorize]

    public class HakkimdaController : Controller
    {
        eCV db = new eCV();
        // GET: Hakkimda
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Hakkimda()
        {

            return View(db.Hakkimda.Where(x=>x.HID==1).SingleOrDefault());
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Hakkimda(Hakkimda h, HttpPostedFileBase pResim, HttpPostedFileBase cvLink)
        {
            Hakkimda hk = db.Hakkimda.Where(x => x.HID == 1).SingleOrDefault();
            hk.hakkimda1 = h.hakkimda1;
            hk.adSoyad = h.adSoyad;
            hk.dogumYili = h.dogumYili;
            hk.mail = h.mail;
            hk.konum = h.konum;
            if (pResim != null && pResim.ContentLength > 0)
            {
                //Resim ekleme 
                string dosyaAdi = Guid.NewGuid().ToString() + Path.GetExtension(pResim.FileName);
                pResim.SaveAs(Server.MapPath("/Resim/" + dosyaAdi));
                hk.pResim = "/Resim/" + dosyaAdi;
            }
            if (cvLink != null)
            {
                string dosyaYolu = Path.GetFileName(cvLink.FileName);
                var yuklemeYeri = Path.Combine(Server.MapPath("/Dosyalar/"), dosyaYolu);
                cvLink.SaveAs(yuklemeYeri);
                hk.cvLink = "/Dosyalar/" + dosyaYolu;

            }
            hk.sayfaBaslik = h.sayfaBaslik;
            db.SaveChanges();
            return Redirect("/Hakkimda/Hakkimda/");
        }
    }
}