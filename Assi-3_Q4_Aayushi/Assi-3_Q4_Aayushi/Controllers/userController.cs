using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assi_3_Q4_Aayushi.Controllers
{
    public class userController : Controller
    {
        // GET: user
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(OddModel model)
        {
            int start = model.InputNumber;

            if (start > 200)
            {
                model.OddNumbers = new List<int>(); // no output
                return View(model);
            }

            if (start % 2 == 0) start++; // make it odd if even

            List<int> result = new List<int>();
            for (int i = start; i <= 200; i += 2)
            {
                result.Add(i);
            }

            model.OddNumbers = result;
            return View(model);
        }

    }
}