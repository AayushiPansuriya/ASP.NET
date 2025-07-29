using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assi_1_Q10_Aayushi.Controllers
{
    public class tenController : Controller
    {
        // GET: ten
        public ActionResult Index()
        {
            return View();
        }
        public string Test10()
        {
            return @"
                            <h2>Result Table</h2>
                            <table border='1'>
                            <tr>
                            <th>Roll No</th>
                            <th>Name</th>
                            <th>Marks</th>
                            <th>Grade</th></tr>

                            <tr>
                            <td>1</td>
                            <td>Ravi</td>
                            <td>85</td>
                            <td>A</td>
                            </tr>

                            <tr>
                            <td>2</td>
                            <td>Kiran</td>
                            <td>78</td>
                            <td>B</td>
                            </tr>

                            <tr>
                            <td>3</td>
                            <td>Komal</td>
                            <td>92</td>
                            <td>A+</td>
                            </tr>

                            <tr>
                            <td>4</td>
                            <td>Jay</td>
                            <td>68</td>
                            <td>C</td>
                            </tr>

                            <tr>
                            <td>5</td>
                            <td>Seema</td>
                            <td>74</td>
                            <td>B</td>
                            </tr>

                            </table>
                            ";
        }
    }
}