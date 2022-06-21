using System.Web;
using System.Web.Mvc;

namespace TP3.EF.TP8.APIRQ
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
