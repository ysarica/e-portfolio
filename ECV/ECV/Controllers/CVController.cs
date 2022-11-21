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

    public class CVController : Controller
    {
        // GET: CV
        eCV db = new eCV();
        public PartialViewResult _EgitimListe()
        {
           return PartialView(db.EgitimBilgi.ToList());
        }
        public ActionResult EgitimEkle()
        {

            return View();
        }
        [HttpPost]
        public ActionResult EgitimEkle(EgitimBilgi e)
        {
            db.EgitimBilgi.Add(e);
            db.SaveChanges();
            return Redirect("/CV/EgitimEkle");
        }
        public ActionResult EgitimDuzenle(int EID)
        {
            return View(db.EgitimBilgi.Where(x=> x.EID==EID).SingleOrDefault());
        }
        [HttpPost]
        public ActionResult EgitimDuzenle(EgitimBilgi e, int EID)
        {
            EgitimBilgi eg = db.EgitimBilgi.Where(x => x.EID == EID).SingleOrDefault();
            eg.egitimTürü = e.egitimTürü;
            eg.bölüm = e.bölüm;
           
            eg.okul = e.okul;
            eg.yil = e.yil;
            db.SaveChanges();
            return Redirect("/CV/EgitimEkle");
        }
        public ActionResult EgitimSil(int EID)
        {
            EgitimBilgi e = db.EgitimBilgi.Where(x => x.EID == EID).SingleOrDefault();
            db.EgitimBilgi.Remove(e);
            db.SaveChanges();
            return Redirect("/CV/EgitimEkle");
        }

        //-----------------Eğitim Son-----------------------//

        public PartialViewResult _DeneyimListe()
        {
            return PartialView(db.Deneyim.ToList());
        }
        public ActionResult DeneyimEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DeneyimEkle(Deneyim d)
        {
            db.Deneyim.Add(d);
            db.SaveChanges();
            return Redirect("/CV/DeneyimEkle");
        }
        public ActionResult DeneyimDuzenle(int DID)
        {
            return View(db.Deneyim.Where(x=> x.DID==DID).SingleOrDefault());
        }
        [HttpPost]
        public ActionResult DeneyimDuzenle(int DID,Deneyim d)
        {
            Deneyim de = db.Deneyim.Where(x => x.DID == DID).SingleOrDefault() ;
            de.firmaAdi = d.firmaAdi;
            de.unvan = d.unvan;
            de.yil = d.yil;
            de.tecrübe = d.tecrübe;
            db.SaveChanges();
            return Redirect("/CV/DeneyimEkle");
        }
        public ActionResult DeneyimSil(int DID)
        {
            Deneyim de = db.Deneyim.Where(x=> x.DID==DID).SingleOrDefault();
            db.Deneyim.Remove(de);
            db.SaveChanges();
            return Redirect("/CV/DeneyimEkle");
        }

        //---------------------Deneyim Son-------------------//
        public PartialViewResult _HobiListe()
        {
            return PartialView(db.Hobiler.ToList());
        }
        public ActionResult HobiEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult HobiEkle(Hobiler h)
        {
            db.Hobiler.Add(h);
            db.SaveChanges();
            return Redirect("/CV/HobiEkle");
        }
        public ActionResult HobiDuzenle(int HID)
        {
            return View(db.Hobiler.Where(x=> x.HID==HID).SingleOrDefault());
        }
        [HttpPost]
        public ActionResult HobiDuzenle(int HID,Hobiler h)
        {
            Hobiler he = db.Hobiler.Where(x => x.HID == HID).SingleOrDefault();
            he.hobi = h.hobi;
            he.icon = h.icon;
            db.SaveChanges();
            return Redirect("/CV/HobiEkle");
        }
        public ActionResult HobiSil(int HID)
        {
            Hobiler h = db.Hobiler.Where(x => x.HID == HID).SingleOrDefault();
            db.Hobiler.Remove(h);
            db.SaveChanges();
            return Redirect("/CV/HobiEkle");
        }
        public PartialViewResult _YetenekListe()
        {

            return PartialView(db.Yetenekler.ToList());
        }
        public ActionResult YetenekEkle()
        {

            return View();
        }
        [HttpPost]
        public ActionResult YetenekEkle(Yetenekler y)
        {
            db.Yetenekler.Add(y);
            db.SaveChanges();
            return Redirect("/CV/YetenekEkle");
        }
        public ActionResult YetenekDuzenle(int YID)
        {
            return View(db.Yetenekler.Where(x=> x.YID==YID).SingleOrDefault());
        }
        [HttpPost]
        public ActionResult YetenekDuzenle(int YID,Yetenekler y)
        {
            Yetenekler ye = db.Yetenekler.Where(x => x.YID == YID).SingleOrDefault();
            ye.adi = y.adi;
            ye.yüzde = y.yüzde;
            db.SaveChanges();
            return Redirect("/CV/YetenekEkle");
        }
        public ActionResult YetenekSil(int YID)
        {
            Yetenekler ye = db.Yetenekler.Where(x => x.YID == YID).SingleOrDefault();
            db.Yetenekler.Remove(ye);
            db.SaveChanges();
            return Redirect("/CV/YetenekEkle");
        }
    }
}