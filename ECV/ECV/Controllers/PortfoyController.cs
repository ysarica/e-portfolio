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

    public class PortfoyController : Controller
    {
        eCV db = new eCV();
        // GET: Portfoy
        public PartialViewResult _pKategoriListe()
        {
            return PartialView(db.PortfoyKategori.ToList());
        }
        public ActionResult pKategoriEkle()
        {

            return View();
        }
        [HttpPost]
        public ActionResult pKategoriEkle(PortfoyKategori pk)
        {
            db.PortfoyKategori.Add(pk);
            db.SaveChanges();
            return Redirect("/Portfoy/pKategoriEkle");
        }
        public ActionResult pKategoriDuzenle(int PKID)
        {
            return View(db.PortfoyKategori.Where(x => x.PKID == PKID).SingleOrDefault());
        }
        [HttpPost]
        public ActionResult pKategoriDuzenle(int PKID, PortfoyKategori pk)
        {
            PortfoyKategori p = db.PortfoyKategori.Where(x => x.PKID == PKID).SingleOrDefault();
            p.kategoriAdi = pk.kategoriAdi;
            db.SaveChanges();
            return Redirect("/Portfoy/pKategoriEkle");
        }
        public ActionResult pKategoriSil(int PKID)
        {
            PortfoyKategori p = db.PortfoyKategori.Where(x => x.PKID == PKID).SingleOrDefault();
            db.PortfoyKategori.Remove(p);
            db.SaveChanges();
            return Redirect("/Portfoy/pKategoriEkle");
        }
        public PartialViewResult _PortfoyListe()
        {
            return PartialView(db.Portfoy.ToList());
        }
        public ActionResult PortfoyEkle()
        {
            ViewBag.pKategori = db.PortfoyKategori.ToList();
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult PortfoyEkle(Portfoy p, HttpPostedFileBase resim)
        {
            if (resim != null && resim.ContentLength > 0)
            {
                string dosyaAdi = Guid.NewGuid().ToString() + Path.GetExtension(resim.FileName);
                resim.SaveAs(Server.MapPath("/Resim/" + dosyaAdi));
                p.resim = "/Resim/" + dosyaAdi;
                p.tarih = DateTime.Now.ToLongDateString().ToString();
            }
            db.Portfoy.Add(p);
            db.SaveChanges();
            return Redirect("/Portfoy/PortfoyEkle");
        }
        public ActionResult PortfoyDuzenle(int PID)
        {
            ViewBag.pKategori = db.PortfoyKategori.ToList();

            return View(db.Portfoy.Where(x=> x.PID==PID).SingleOrDefault());
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult PortfoyDuzenle(int PID,Portfoy p, HttpPostedFileBase resim)
        {
            Portfoy pr = db.Portfoy.Where(x => x.PID == PID).SingleOrDefault();
            pr.kategori = p.kategori;
            if (resim != null && resim.ContentLength > 0)
            {
                string dosyaAdi = Guid.NewGuid().ToString() + Path.GetExtension(resim.FileName);
                resim.SaveAs(Server.MapPath("/Resim/" + dosyaAdi));
                pr.resim = "/Resim/" + dosyaAdi;
                pr.tarih = DateTime.Now.ToLongDateString().ToString();
            }
            pr.kime = p.kime;
            pr.süre = p.süre;
            pr.aciklama = p.aciklama;
            db.SaveChanges();
            return Redirect("/Portfoy/PortfoyEkle");
        }
        public ActionResult PortfoySil(int PID)
        {
            Portfoy pr = db.Portfoy.Where(x => x.PID == PID).SingleOrDefault();
            db.Portfoy.Remove(pr);
            db.SaveChanges();
            return Redirect("/Portfoy/PortfoyEkle");
        }
    }
}