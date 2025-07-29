using System.Web;
using System.Web.Mvc;

namespace Assi_3_Q2_Aayushi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
