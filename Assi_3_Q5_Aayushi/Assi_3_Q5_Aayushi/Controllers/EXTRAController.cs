using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assi_3_Q5_Aayushi.Controllers
{
    public class EXTRAController : Controller
    {
        // GET: EXTRA
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index1()
        {

            ViewBag.value = 23;
            ViewBag.firstvalue = ViewBag.value / 10;
            ViewBag.secondvalue = ViewBag.value % 10;
            ViewBag.multiplication = ViewBag.firstvalue * ViewBag.secondvalue; 
            return View();
        }
    }
}