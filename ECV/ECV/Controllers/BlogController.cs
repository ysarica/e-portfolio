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
    public class BlogController : Controller
    {
        

        eCV db = new eCV();
        // GET: Blog
        public PartialViewResult _bKategoriListe()
        {
            return PartialView(db.blogKategori.ToList());
        }
        public ActionResult bKategoriEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult bKategoriEkle(blogKategori k)
        {
            db.blogKategori.Add(k);
            db.SaveChanges();
            return Redirect("/Blog/bKategoriEkle");
        }
        public ActionResult bKategoriDuzenle(int BKID)
        {
            return View(db.blogKategori.Where(x=> x.BKID==BKID).SingleOrDefault());
        }
        [HttpPost]
        public ActionResult bKategoriDuzenle(int BKID,blogKategori bk)
        {
            blogKategori b = db.blogKategori.Where(x => x.BKID == BKID).SingleOrDefault();
            b.kategoriAdi = bk.kategoriAdi;
            db.SaveChanges();
            return Redirect("/Blog/bKategoriEkle");
        }
        public ActionResult bKategoriSil(int BKID)
        {
            blogKategori b = db.blogKategori.Where(x => x.BKID == BKID).SingleOrDefault();
            db.blogKategori.Remove(b);
            db.SaveChanges();
            return Redirect("/Blog/bKategoriEkle");

        }
        public PartialViewResult _BlogListe()
        {
            return PartialView(db.blog.ToList());
        }
        public ActionResult BlogEkle()
        {
            ViewBag.bKategori = db.blogKategori.ToList();
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult BlogEkle(blog b, HttpPostedFileBase resim)
        {

            blog bl = new blog();
            if (ModelState.IsValid)
            {
                if (resim != null && resim.ContentLength > 0)
                {
                    string dosyaAdi = Guid.NewGuid().ToString() + Path.GetExtension(resim.FileName);
                    resim.SaveAs(Server.MapPath("/Resim/" + dosyaAdi));
                    bl.resim = "/Resim/" + dosyaAdi;
                }
                bl.kategoriAd = b.kategoriAd;
                bl.baslik = b.baslik;
                bl.tarih = DateTime.Now.ToLongDateString().ToString();
                bl.ozetaciklama = b.ozetaciklama;
                bl.aciklama = b.aciklama;
                db.blog.Add(bl);
                db.SaveChanges();
            }
            return Redirect("/Blog/BlogEkle");
        }
        public ActionResult BlogDuzenle(int BID)
        {
            ViewBag.bKategori = db.blogKategori.ToList();
            return View(db.blog.Where(x=> x.BID==BID).SingleOrDefault());
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult BlogDuzenle(int BID,blog b, HttpPostedFileBase resim)
        {
            blog bl = db.blog.Where(x => x.BID == BID).SingleOrDefault();
            bl.kategoriAd = b.kategoriAd;
            if (resim != null && resim.ContentLength > 0)
            {
                //Resim ekleme 
                string dosyaAdi = Guid.NewGuid().ToString() + Path.GetExtension(resim.FileName);
                resim.SaveAs(Server.MapPath("/Resim/" + dosyaAdi));
                bl.resim = "/Resim/" + dosyaAdi;
            }
            bl.baslik = b.baslik;
            bl.tarih = DateTime.Now.ToLongDateString();
            bl.ozetaciklama = b.ozetaciklama;
            bl.aciklama = b.aciklama;
            db.SaveChanges();
            return Redirect("/Blog/BlogEkle");
        }
        public ActionResult BlogSil(int BID)
        {
            blog bl = db.blog.Where(x => x.BID == BID).SingleOrDefault();
            db.blog.Remove(bl);
            db.SaveChanges();
            return Redirect("/Blog/BlogEkle");
        }
    }
}