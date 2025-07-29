using System.Web;
using System.Web.Mvc;

namespace Assi_1_Q7_Aayushi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
