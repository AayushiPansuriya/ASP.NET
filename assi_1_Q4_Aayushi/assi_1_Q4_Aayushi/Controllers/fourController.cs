using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace assi_1_Q4_Aayushi.Controllers
{
    public class fourController : Controller
    {
        // GET: four
        public ActionResult Index()
        {
            return View();
        }
        public string Test4()
        {
            return @"
                <h1>Clothes Inventory</h1>
                <table border='1'>

                <tr>
                <th>Item</th>
                <th>Size</th>
                <th>Price</th>
                </tr>

                <tr>
                <td>T-Shirt</td>
                <td>M</td>
                <td>$20</td>
                </tr>

                <tr>
                <td>Jeans</td>
                <td>L</td>
                <td>$40</td>
                </tr>

                <tr>
                <td>Jacket</td>
                <td>XL</td>
                <td>$60</td>
                </tr>

                <tr>
                <td>Kurti</td>
                <td>M</td>
                <td>$25</td>
                </tr>

                <tr>
                <td>Saree</td>
                <td>Free</td>
                <td>$50</td>
                </tr>

                </table>";
        }
    }
}