using System.Diagnostics;
using System.Web.Mvc;

namespace AspNetFundamentos.Capitulo07.AcessoDados.Filtros
{
    public class LogErrorAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);
            Debug.WriteLine( filterContext.Exception);
        }
    }
}