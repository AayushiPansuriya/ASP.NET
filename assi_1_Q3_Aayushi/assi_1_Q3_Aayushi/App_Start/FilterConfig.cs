using System.Web;
using System.Web.Mvc;

namespace assi_1_Q3_Aayushi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
