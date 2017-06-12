using System.Web.Mvc;

namespace AspNetFundamentos.Capitulo04.Mvc.Controllers
{
    public class BlogController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}