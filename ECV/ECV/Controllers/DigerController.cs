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

    public class DigerController : Controller
    {
        eCV db = new eCV();
        // GET: Diger
        public PartialViewResult _YorumListele()
        {
            return PartialView(db.Yorum.ToList());
        }
        public ActionResult YorumEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YorumEkle(Yorum y)
        {
            db.Yorum.Add(y);
            db.SaveChanges();
            return Redirect("/Diger/YorumEkle");
        }
        public ActionResult YorumDuzenle(int YID)
        {
            return View(db.Yorum.Where(x=> x.YID==YID).SingleOrDefault());
        }
        [HttpPost]
        public ActionResult YorumDuzenle(int YID,Yorum y)
        {
            Yorum yr = db.Yorum.Where(x => x.YID == YID).SingleOrDefault();
            yr.yorum1 = y.yorum1;
            yr.adSoyad = y.adSoyad;
            yr.unvan = y.unvan;
            db.SaveChanges();
            return Redirect("/Diger/YorumEkle");
        }
        public ActionResult YorumSil(int YID)
        {
            Yorum yr = db.Yorum.Where(x => x.YID == YID).SingleOrDefault();
            db.Yorum.Remove(yr);
            db.SaveChanges();
            return Redirect("/Diger/YorumEkle");
        }

        //------------------------------------YORUM BİTİŞ--------------------------------//
        public PartialViewResult _SosyalListe()
        {

            return PartialView(db.Sosyal.ToList());
        }
        public ActionResult SosyalEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SosyalEkle(Sosyal s)
        {
            db.Sosyal.Add(s);
            db.SaveChanges();
            return Redirect("/Diger/SosyalEkle");
        }
        public ActionResult SosyalDuzenle(int SID)
        {
            return View(db.Sosyal.Where(x=> x.SID==SID).SingleOrDefault());
        }
        [HttpPost]
        public ActionResult SosyalDuzenle(int SID,Sosyal s)
        {
            Sosyal ss = db.Sosyal.Where(x => x.SID == SID).SingleOrDefault();
            ss.icon = s.icon;
            ss.link = s.link;
            db.SaveChanges();
            return Redirect("/Diger/SosyalEkle");
        }
        public ActionResult SosyalSil(int SID)
        {
            Sosyal ss = db.Sosyal.Where(x => x.SID == SID).SingleOrDefault();
            db.Sosyal.Remove(ss);
            db.SaveChanges();
            return Redirect("/Diger/SosyalEkle");
        }
        //--------------------------SOSYAL BİTİŞ-------------------------------//
        public ActionResult SurecListe()
        {
            return View(db.Surec.ToList());
        }
        public ActionResult SurecDuzenle(int SID)
        {
            return View(db.Surec.Where(x => x.SID == SID).SingleOrDefault());
        }
        [HttpPost]
        public ActionResult SurecDuzenle(int SID,Surec s)
        {
            Surec sr = db.Surec.Where(x=> x.SID==SID).SingleOrDefault();
            sr.baslik = s.baslik;
            sr.aciklama = s.aciklama;
            db.SaveChanges();
            return Redirect("/Diger/SurecListe");
        }

        //------------------------------------SUREC BİTİŞ-------------------------//
        public ActionResult SiteAyar()
        {
            return View(db.SiteAyar.Where(x=> x.ID==1).SingleOrDefault());
        }
        [HttpPost]
        public ActionResult SiteAyar(SiteAyar s)
        {
            SiteAyar sa = db.SiteAyar.Where(x => x.ID == 1).SingleOrDefault();
            sa.title = s.title;
            sa.keywords = s.keywords;
            sa.aciklama = s.aciklama;
            sa.anarenk = s.anarenk;
            sa.ararenk = s.ararenk;
            sa.ozellik1 = s.ozellik1;
            sa.ozellik2 = s.ozellik2;
            sa.ozellik3 = s.ozellik3;
            sa.blog = s.blog;
            sa.hizmet = s.hizmet;
            sa.iletisim = s.iletisim;
            sa.portfoy = s.portfoy;
            db.SaveChanges();
            return Redirect("/Diger/SiteAyar");
        }

        //--------------------Site Ayar------------------------------//

        public PartialViewResult Ad()
        {
            return PartialView(db.Hakkimda.ToList());
        }
        public PartialViewResult Whatsapp()
        {
            return PartialView(db.Hakkimda.ToList());
        }
    }
}