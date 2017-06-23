using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using AspNetFundamentos.Capitulo07.AcessoDados.Models;

namespace AspNetFundamentos.Capitulo07.AcessoDados.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            if (loginViewModel.Login == "abc" && loginViewModel.Senha == "123")
            {
                var identity = new ClaimsIdentity(new[] {
                        new Claim(ClaimTypes.Name, loginViewModel.Login),
                        new Claim(ClaimTypes.NameIdentifier, loginViewModel.Login)
                    },
                    "ApplicationCookie");

                var ctx = Request.GetOwinContext();
                var authManager = ctx.Authentication;

                authManager.SignIn(identity);

                return RedirectToAction("Index", "Tarefas");
            }

            ModelState.AddModelError(string.Empty, "Login e/ou senha inválidos.");

            return View(loginViewModel);
        }

        public ActionResult LogOut()
        {
            var ctx = Request.GetOwinContext();
            var authManager = ctx.Authentication;

            authManager.SignOut("ApplicationCookie");
            return RedirectToAction("index", "home");
        }
    }
}