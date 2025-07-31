using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assi_3_Q5_Aayushi.Controllers
{
    public class DigitController : Controller
    {
        // GET: Digit
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string inputNumber)
        {
            ViewBag.Input = inputNumber;

            if (string.IsNullOrWhiteSpace(inputNumber))
            {
                ViewBag.Error = "Please enter a valid number.";
                return View();
            }

            int result = 1;
            foreach (char ch in inputNumber)
            {
                if (!char.IsDigit(ch))
                {
                    ViewBag.Error = "Only digits are allowed.";
                    return View();
                }
                result *= (ch - '0');
            }

            ViewBag.Result = result;

            if (result >= 0 && result <= 9)
            {
                // Single digit - show multiplication table
                string table = "";
                for (int i = 1; i <= 10; i++)
                {
                    table += $"{result} * {i} = {result * i}<br/>";
                }
                ViewBag.Table = table;
            }
            else
            {
                // Not single digit - show result only
                ViewBag.Table = null;
            }

            return View();
        }
    }
}