using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assi_1_Q1_Aaayushi.Controllers
{
    public class firstController : Controller
    {
        // GET: first
        public ActionResult Index()
        {
            return View();
        }

        public String Test1()
        {


            return @"
                  <table border: 1px solid black;
                border - radius: 10px;
            }>
  <tr>
    <th>Firstname</th>
    <th>Lastname</th>
    <th>Age</th>
    
  </tr>
  <tr>
    <td>Jill</td>
    <td>voyra</td>
    <td>50</td> 
  </tr>
  <tr>
    <td>Eve</td>
    <td>Jackson</td>
    <td>94</td>
  </tr>
</table>
          ";                        




        }
    
    }
}