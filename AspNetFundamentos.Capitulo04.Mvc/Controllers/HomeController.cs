using System.Configuration;
using System.Data.SqlClient;
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

            return View();
        }
    }
}