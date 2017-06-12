using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using AspNetFundamentos.Capitulo04.Mvc.Models;
using System.Web.Mvc;
using System.Web;
using System;

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
            const string diretorioImagens = "/Content/Imagens/Portfolio";
            var caminhos = Directory.EnumerateFiles(Server.MapPath(diretorioImagens));

            var porftolioViewModel = new PorftolioViewModel();
            porftolioViewModel.CaminhosImagem = new List<string>();

            foreach (var caminho in caminhos)
            {
                porftolioViewModel.CaminhosImagem.Add($"{diretorioImagens}/{Path.GetFileName(caminho)}");
            }

            return View(porftolioViewModel);
        }

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        //[ActionName("Contact")]
        [ValidateAntiForgeryToken]
        //public ActionResult Contact(FormCollection controles)
        //public ActionResult Contact(string mensagem, string nome, string email)
        public ActionResult /*GravarContato*/ Contact(ContatoViewModel contato)
        {
            //var nome = controles["nome"];

            if (!ModelState.IsValid)
            {
                return View(contato);
            }

            Session[nameof(contato.Nome)] = contato.Nome;

            GravarCookie(contato);

            using (var conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["portfolioConnectionString"].ConnectionString))
            {
                conexao.Open();

                const string instrucao = @"INSERT INTO [dbo].[Contato]
                                                ([Nome]
                                                ,[Email]
                                                ,[Mensagem])
                                            VALUES
                                                (@Nome
                                                ,@Email
                                                ,@Mensagem)";

                using (var comando = new SqlCommand(instrucao, conexao))
                {
                    comando.Parameters.AddWithValue("@Nome", contato.Nome);
                    comando.Parameters.AddWithValue("@Email", contato.Email);
                    comando.Parameters.AddWithValue("@Mensagem", contato.Mensagem);

                    comando.ExecuteNonQuery();
                }
            }

            ViewBag.Sucesso = true;
            //ViewBag.Sucesso = "";

            //object meuObjeto = true;
            //meuObjeto = ""; // :)
            //meuObjeto.Propriedade = 5; // :(

            ModelState.Clear();

            return View();
        }

        private void GravarCookie(ContatoViewModel contato)
        {
            var cadastroCookie = new HttpCookie("cadastroPortfolio");
            cadastroCookie.Values.Add("nome", Server.UrlEncode(contato.Nome));
            cadastroCookie.Values.Add("email", contato.Email);
            cadastroCookie.Expires = DateTime.Now.AddMonths(1);
            cadastroCookie.HttpOnly = true;

            Response.Cookies.Set(cadastroCookie);
        }

        public ActionResult Sair()
        {
            //1o. Comentar abaixo para comparar o ViewBag com o TempData.
            //Session.Abandon();
            Session.Remove("Nome");

            //2o. Comparação do ViewBag com o TempData.
            ViewBag.Mensagem = "Logout - Viewbag";
            //ViewData["Mensagem"] = "Logout - TempData";
            TempData["Mensagem"] = "Logout - TempData";

            //3o. Cookies
            if (Request.Cookies["cadastroPortfolio"] != null)
            {
                Response.Cookies["cadastroPortfolio"].Expires = DateTime.Now;
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
