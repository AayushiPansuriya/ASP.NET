using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assi_1_Q8_Aayushi.Controllers
{
    public class eightController : Controller
    {
        // GET: eight
        public ActionResult Index()
        {
            return View();
        }
        public string Test8()
        {
            return @"
                <h2>Movie Table</h2>
                <table border='1'>
                <tr>
                <th>ID</th>
                <th>Title</th>
                <th>Genre</th>
                <th>Year</th>
                </tr>

                <tr>
                <td>1</td>
                <td>3 Idiots</td>
                <td>Comedy</td>
                <td>2009</td>
                </tr>

                <tr>
                <td>2</td>
                <td>Dangal</td>
                <td>Drama</td>
                <td>2016</td>
                </tr>

                <tr>
                <td>3</td>
                <td>Pathaan</td>
                <td>Action</td>
                <td>2023</td>
                </tr>

                <tr>
                <td>4</td>
                <td>RRR</td>
                <td>Action</td>
                <td>2022</td>
                </tr>

                <tr>
                <td>5</td>
                <td>Drishyam 2</td>
                <td>Thriller</td>
                <td>2022</td>
                </tr>
                </table>
                ";
        }
    }
}