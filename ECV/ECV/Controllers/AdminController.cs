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

    public class AdminController : Controller
    {
        eCV db = new eCV();
        // GET: Admin
        public ActionResult SifreDegistir()
        {
            return View(db.Admin.Where(x=> x.AID==1).SingleOrDefault());
        }
        [HttpPost]
        public ActionResult SifreDegistir(Admin a)
        {
            Admin ad = db.Admin.Where(x => x.AID == 1).SingleOrDefault();
            ad.pw = a.pw;
            db.SaveChanges();
            return Redirect("/Admin/SifreDegistir");
        }
    }
}