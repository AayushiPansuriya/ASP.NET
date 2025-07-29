using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assi_1_Q9_Aayushi.Controllers
{
    public class nineController : Controller
    {
        // GET: nine
        public ActionResult Index()
        {
            return View();
        }
        public string Test9()
        {
            return @"
                <h2>Library Table</h2>
                <table border='1'>
                <tr>
                <th>ID</th><th>Book Title</th><th>Author</th><th>Year</th></tr>

                <tr>
                <td>1</td>
                <td>Wings of Fire</td>
                <td>APJ Abdul Kalam</td>
                <td>1999</td>
                </tr>

                <tr>
                <td>2</td>
                <td>The Alchemist</td>
                <td>Paulo Coelho</td>
                <td>1988</td>
                </tr>

                <tr>
                <td>3</td>
                <td>Atomic Habits</td>
                <td>James Clear</td>
                <td>2018</td>
                </tr>

                <tr>
                <td>4</td>
                <td>The Secret</td>
                <td>Rhonda Byrne</td>
                <td>2006</td>
                </tr>

                <tr>
                <td>5</td>
                <td>Ikigai</td>
                <td>Héctor García</td>
                <td>2016</td>
                </tr>

                </table>
                ";
        }
    }
}