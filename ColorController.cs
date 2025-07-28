using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aasi_3_Q3_Aayushi.Controllers
{
    public class ColorController : Controller
    {
        // GET: Color
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult test3()
        {
            ViewBag.value = 3;

            ViewBag.valA = 20;
            ViewBag.vaLB = 30;

            ViewBag.val = 700;

            return View();
        }
    }
}