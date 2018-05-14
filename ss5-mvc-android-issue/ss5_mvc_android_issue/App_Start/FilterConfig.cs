using System.Web;
using System.Web.Mvc;

namespace ss5_mvc_android_issue
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
