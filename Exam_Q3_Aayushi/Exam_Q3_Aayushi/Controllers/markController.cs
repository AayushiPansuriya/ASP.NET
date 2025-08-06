using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exam_Q3_Aayushi.Controllers
{
    public class markController : Controller
    {
        // GET: mark
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult mark()
        {
            ViewBag.java = 60;
            ViewBag.xtml = 70;
            ViewBag.android = 80;
            ViewBag.asp = 85;
            ViewBag.ml = 90;
            ViewBag.totalmark = ViewBag.java + ViewBag.xtml + ViewBag.android + ViewBag.asp + ViewBag.ml;
            ViewBag.percentage = ViewBag.totalmark / 5;
            return View();
        }
    }
}