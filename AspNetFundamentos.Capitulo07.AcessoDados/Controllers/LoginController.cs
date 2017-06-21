using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using AspNetFundamentos.Capitulo07.AcessoDados.Models;

namespace AspNetFundamentos.Capitulo07.AcessoDados.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel loginViewModel)
        {
            if (loginViewModel.Login == "abc" && loginViewModel.Senha == "123")
            {
                var identity = new ClaimsIdentity(new[] {
                        new Claim(ClaimTypes.Name, loginViewModel.Login)
                    },
                    "ApplicationCookie");

                var ctx = Request.GetOwinContext();
                var authManager = ctx.Authentication;

                authManager.SignIn(identity);

                return RedirectToAction("Index", "Tarefas");
            }

            ModelState.AddModelError(string.Empty, "Login ou senha inválidos.");

            return View(loginViewModel);
        }
    }
}