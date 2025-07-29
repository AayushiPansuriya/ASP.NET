using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assi_1_Q5_Aayushi.Controllers
{
    public class fiveController : Controller
    {
        // GET: five
        public ActionResult Index()
        {
            return View();
        }
        public string Test5()
        {
            return @"
                <h1>Company Details</h1>
                <table border='1'>

                <tr>
                <th>Company Name</th>
                <th>Location</th>
                <th>Employees</th>
                </tr>

                <tr>
                <td>Google</td>
                <td>California</td>
                <td>100000</td>
                </tr>

                <tr>
                <td>Microsoft</td>
                <td>Redmond</td>
                <td>150000</td>
                </tr>

                <tr>
                <td>TCS</td>
                <td>India</td>
                <td>400000</td>
                </tr>

                <tr>
                <td>Infosys</td>
                <td>Bangalore</td>
                <td>300000</td>
                </tr>

                <tr>
                <td>Apple</td>
                <td>California</td>
                <td>120000</td>
                </tr>

                </table>";
        }
    }
}