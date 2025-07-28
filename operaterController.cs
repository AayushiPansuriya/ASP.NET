using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assi_3_Q2_Aayushi.Controllers
{
    public class operaterController : Controller
    {
        // GET: operater
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult test2()
        {

            ViewBag.valueA = 10;
            ViewBag.valueB = 20;
           /* ViewBag.Sum = sum;*/

            return View();
        }
    }
}