using System.Web;
using System.Web.Mvc;

namespace AspNetFundamentos.Capitulo04.Mvc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
