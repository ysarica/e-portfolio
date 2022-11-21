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

    public class MesajController : Controller
    {
        eCV db = new eCV();
        // GET: Mesaj
        public ActionResult MesajListe()
        {
            return View(db.GelenMesaj.ToList());
        }
        public ActionResult MesajSil(int MID)
        {

            GelenMesaj m = db.GelenMesaj.Where(x => x.MID == MID).SingleOrDefault();
            db.GelenMesaj.Remove(m);
            db.SaveChanges();
            return Redirect("/Mesaj/MesajListe");
        }
       
    }
}