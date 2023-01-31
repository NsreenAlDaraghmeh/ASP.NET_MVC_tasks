using System.Web;
using System.Web.Mvc;

namespace _31._01._2023_ASP.NET_MVC_tasks
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
