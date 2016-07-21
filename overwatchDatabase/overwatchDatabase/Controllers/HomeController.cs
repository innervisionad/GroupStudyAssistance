using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using overwatchDatabase.Models;
using System.Net;

namespace overwatchDatabase.Controllers
{
    public class HomeController : Controller
    {
        private overBaseEntities db = new overBaseEntities();

        // GET: Home
        public ActionResult Index()
        {
            var heros = from h in db.
                        select h;
            return View(heros);
        }
    }
}