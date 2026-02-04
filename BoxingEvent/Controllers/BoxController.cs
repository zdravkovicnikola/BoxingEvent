using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoxingEvent.Controllers
{
    public class BoxController : Controller
    {
        // GET: Box
        public ActionResult Index()
        {
            ViewData["Poruka"] = "Dobrodosli na stranicu o boksu!";
            ViewBag.Poruka = "Dobrodosli na stranicu o boksu!";
            return View();
        }
    }
}