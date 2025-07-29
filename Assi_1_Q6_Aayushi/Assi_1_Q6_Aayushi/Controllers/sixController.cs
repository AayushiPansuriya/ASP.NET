using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assi_1_Q6_Aayushi.Controllers
{
    public class sixController : Controller
    {
        // GET: six
        public ActionResult Index()
        {
            return View();
        }
        public string Test6()
        {
            return @"
                <h1>Product Details</h1>
                <table border='1'>

                <tr>
                <th>Product ID</th>
                <th>Name</th>
                <th>Price</th>
                </tr>

                <tr>
                <td>101</td>
                <td>Pen</td>
                <td>$2</td>
                </tr>

                <tr>
                <td>102</td>
                <td>Notebook</td>
                <td>$5</td>
                </tr>

                <tr>
                <td>103</td>
                <td>Bag</td>
                <td>$20</td>
                </tr>

                <tr>
                <td>104</td>
                <td>Calculator</td>
                <td>$15</td>
                </tr>

                <tr>
                <td>105</td>
                <td>Mouse</td>
                <td>$10</td>
                </tr>

                </table>";
        }
    }
}