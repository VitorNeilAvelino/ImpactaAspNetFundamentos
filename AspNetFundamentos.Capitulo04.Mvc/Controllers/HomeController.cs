using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
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
            const string diretorioImagens = "~/Content/Imagens/Portfolio";
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

            ModelState.Clear();

            return View();
        }
    }
}