using System;
using System.IO;

namespace AspNetFundamentos.Capitulo03.WebForms.Candidatos
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gravarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsValid)
                {
                    return;
                }

                var caminho = Server.MapPath("~/Candidatos/Cadastro.csv");
                var registro = string.Format("{0};{1};{2};{3};{4}",
                    nomeTextBox.Text,
                    nascimentoTextBox.Text,
                    emailTextBox.Text,
                    estadoDropDownList.Text,
                    pretensaoTextBox.Text);

                using (var arquivoCandidatos = new StreamWriter(caminho, true))
                {
                    arquivoCandidatos.WriteLine(registro);
                }

                ExibirMensagem("Cadastro efetuado com sucesso.");
            }
            catch
            {
                ExibirMensagem("Erro ao efetuar o cadastro.");
            }
        }

        private void ExibirMensagem(string mensagem)
        {
            cadastroMultiView.ActiveViewIndex = 1;
            mensagemLabel.Text = mensagem;
        }

        private void LimparFormulario()
        {
            nomeTextBox.Text = string.Empty;
            nascimentoTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            estadoDropDownList.SelectedIndex = -1;
            pretensaoTextBox.Text = string.Empty;
        }

        protected void novoCadastroButton_Click(object sender, EventArgs e)
        {
            LimparFormulario();
            cadastroMultiView.ActiveViewIndex = 0;
        }
    }
}