using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace assi_1_Q3_Aayushi.Controllers
{
    public class threeController : Controller
    {
        // GET: three
        public ActionResult Index()
        {
            return View();
        }

        public string Test3()
        {

            return @"
                <h1>Mobile Shop</h1>
                <table border='1'>

                        <tr>
                        <th>Brand</th>
                        <th>Model</th>
                        <th>Price</th>
                        </tr>

                        <tr>
                        <td>Samsung</td>
                        <td>Galaxy S21</td>
                        <td>$700</td>
                        </tr>

                        <tr>
                        <td>Apple</td>
                        <td>iPhone 13</td>
                        <td>$900</td>
                        </tr>

                        <tr>
                        <td>Realme</td>
                        <td>Realme 11</td>
                        <td>$250</td>
                        </tr>

                        <tr>
                        <td>Xiaomi</td>
                        <td>Redmi Note 12</td>
                        <td>$200</td>
                        </tr>


                        <tr>
                        <td>OnePlus</td>
                        <td>OnePlus Nord 2</td>
                        <td>$400</td>
                        </tr>
                        </table>";
        }
    }
}