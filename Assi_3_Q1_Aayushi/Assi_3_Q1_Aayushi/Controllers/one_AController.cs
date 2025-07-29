using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assi_3_Q1_Aayushi.Controllers
{
    public class one_AController : Controller
    {
        // GET: one_A
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Test1()
        {
            ViewBag.value = 5;
            return View();
        }
    }
}