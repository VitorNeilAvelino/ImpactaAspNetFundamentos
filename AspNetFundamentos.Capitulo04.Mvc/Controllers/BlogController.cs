using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetFundamentos.Capitulo04.Mvc.Controllers
{
    public class BlogController : Controller
    {
        // GET: Veiculos
        public ActionResult Index()
        {
            return View();
        }
    }
}