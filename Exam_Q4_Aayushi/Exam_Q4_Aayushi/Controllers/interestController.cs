using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exam_Q4_Aayushi.Controllers
{
    public class interestController : Controller
    {
        // GET: interest
        public ActionResult Index()
        {
        
            return View();
        }

        public ActionResult interest()
        {
            ViewBag.p = 50;
            ViewBag.r = 5;
            ViewBag.t = 15;

            return View();
        }

    }
}