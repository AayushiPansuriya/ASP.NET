using System.Web;
using System.Web.Mvc;

namespace Aasi_3_Q3_Aayushi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
