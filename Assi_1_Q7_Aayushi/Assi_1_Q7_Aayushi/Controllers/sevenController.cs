using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assi_1_Q7_Aayushi.Controllers
{
    public class sevenController : Controller
    {
        // GET: seven
        public ActionResult Index()
        {
            return View();
        }
        public string Test7()
        {
            return @"
                <h2>Mobile Application Table</h2>
                <table border='1'>

                <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Category</th>
                <th>Rating</th>
                </tr>

                <tr>
                <td>1</td>
                <td>Instagram</td>
                <td>Social</td>
                <td>4.5</td>
                </tr>

                <tr>
                <td>2</td>
                <td>WhatsApp</td>
                <td>Messaging</td>
                <td>4.7</td>
                </tr>

                <tr>
                <td>3</td>
                <td>Zoom</td>
                <td>Communication</td>
                <td>4.4</td>
                </tr>

                <tr>
                <td>4</td>
                <td>Spotify</td>
                <td>Music</td>
                <td>4.8</td>
                </tr>

                <tr>
                <td>5</td>
                <td>Google Maps</td>
                <td>Navigation</td>
                <td>4.6</td>
                </tr>

                </table>
                ";
                        }
    }
}