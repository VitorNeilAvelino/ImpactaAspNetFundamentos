using AspNetFundamentos.Capitulo04.Mvc.Models;
using System.Web.Mvc;

namespace AspNetFundamentos.Capitulo04.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Portfolio()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContatoViewModel contato)
        {
            return View();
        }
    }
}