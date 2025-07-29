using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace assi_1_Q2_Aayushi.Controllers
{
    public class twoController : Controller
    {
        // GET: two
        public ActionResult Index()
        {
            return View();
        }
         public String Test2()
         {

            return @"
        
<h1>Resturent details:-</h1>
<table  border=1>

  <tr>
    <th>Customer name</th>
    <th>Menu</th>
  <th>cost</th>
  </tr>
  <tr>
    <td>Peter</td>
    <td>Chines</td>
    <td>$100</td>
  </tr>
  <tr>
    <td>Lois</td>
    <td>South indian</td>
    <td>$150</td>
  </tr>
  <tr>
    <td>Joe</td>
    <td>Italian</td>
    <td>$300</td>
  </tr>
  <tr>
    <td>Cleveland</td>
    <td>Deserrt</td>
    <td>$250</td>
  </tr>
</table>
";
         } 

        }
    }

