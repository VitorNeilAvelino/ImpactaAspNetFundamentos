using System.Web.Mvc;
using AspNetFundamentos.Capitulo07.AcessoDados.Filtros;

namespace AspNetFundamentos.Capitulo07.AcessoDados
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new HandleErrorAttribute());
            filters.Add(new LogErrorAttribute());
            //filters.Add(new AuthorizeAttribute());
        }
    }
}