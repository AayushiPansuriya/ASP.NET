using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exam_Q1_Aayushi.Controllers
{
    public class studentController : Controller
    {
        // GET: student
        public ActionResult Index()
        {
            ViewBag.mark = 65;
            return View();
        }
    }
}