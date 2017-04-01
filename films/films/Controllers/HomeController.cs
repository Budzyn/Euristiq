using films.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace films.Controllers
{
    public class HomeController : Controller
    {
        FilmsContext db = new FilmsContext();


        public ActionResult Index()
        {
            for (var i = 0; i <= 1000;i++ )
            {
                db.Films.Add(new Films ());
            }
            db.SaveChanges();
                return View(db.Films);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}