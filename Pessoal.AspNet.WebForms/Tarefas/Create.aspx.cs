using Impacta.AspNet.Dominio;
using Impacta.AspNet.Repositorios.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pessoal.AspNet.WebForms.Tarefas
{
    public partial class Create : Page
    {
        private TarefaRepositorio _tarefaRepositorio = new TarefaRepositorio();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public List<Prioridade> ObterPrioridades()
        {
            return Enum.GetValues(typeof(Prioridade)).Cast<Prioridade>().ToList();
        }

        protected void gravarButton_Click(object sender, EventArgs e)
        {
            var tarefa = new Tarefa();

            tarefa.Concluida = concluidaCheckBox.Checked;
            tarefa.Nome = nomeTextBox.Text;
            tarefa.Observacoes = observacoesTextBox.Text;

            Enum.TryParse(prioridadeDropDownList.SelectedValue, out Prioridade prioridadeSelecionada);
            tarefa.Prioridade = prioridadeSelecionada;

            _tarefaRepositorio.Inserir(tarefa);

            Response.Redirect("~/Tarefas");
        }
    }
}