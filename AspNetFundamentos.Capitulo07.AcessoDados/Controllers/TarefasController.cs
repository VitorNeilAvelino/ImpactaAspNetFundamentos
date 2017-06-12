using System.Collections.Generic;
using System.Web.Mvc;
using AspNetFundamentos.Capitulo07.AcessoDados.Models;
using Impacta.AspNet.Dominio;
using Impacta.AspNet.Repositorios.SqlServer;

namespace AspNetFundamentos.Capitulo07.AcessoDados.Controllers
{
    public class TarefasController : Controller
    {
        private readonly TarefaRepositorio _tarefaRepositorio = new TarefaRepositorio();

        // GET: Tarefas
        public ActionResult Index()
        {
            var tarefas = _tarefaRepositorio.Selecionar();
            var tarefasViewModel = new List<TarefaViewModel>();

            foreach (var tarefa in tarefas)
            {
                tarefasViewModel.Add(new TarefaViewModel(tarefa));
            }

            return View(tarefasViewModel);
        }

        // GET: Tarefas/Details/5
        public ActionResult Details(int id)
        {
            var tarefa = _tarefaRepositorio.Selecionar(id);

            return View(new TarefaViewModel(tarefa));
        }

        // GET: Tarefas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tarefas/Create
        [HttpPost]
        public ActionResult Create(TarefaViewModel tarefaViewModel)
        {
            try
            {
                _tarefaRepositorio.Inserir(Mapear(tarefaViewModel));

                return RedirectToAction("Index");
            }
            catch
            {
                return View(tarefaViewModel);
            }
        }

        private static Tarefa Mapear(TarefaViewModel tarefaViewModel)
        {
            var tarefa = new Tarefa();

            tarefa.Concluida = tarefaViewModel.Concluida;
            tarefa.Id = tarefaViewModel.Id;
            tarefa.Nome = tarefaViewModel.Nome;
            tarefa.Observacoes = tarefaViewModel.Observacoes;
            tarefa.Prioridade = tarefaViewModel.Prioridade;

            return tarefa;
        }

        // GET: Tarefas/Edit/5
        public ActionResult Edit(int id)
        {
            var tarefa = _tarefaRepositorio.Selecionar(id);

            return View(new TarefaViewModel(tarefa));
        }

        // POST: Tarefas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, TarefaViewModel tarefaViewModel)
        {
            try
            {
                var tarefa = Mapear(tarefaViewModel);

                _tarefaRepositorio.Atualizar(tarefa);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(tarefaViewModel);
            }
        }

        // GET: Tarefas/Delete/5
        public ActionResult Delete(int id)
        {
            var tarefa = _tarefaRepositorio.Selecionar(id);

            return View(new TarefaViewModel(tarefa));
        }

        // POST: Tarefas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, TarefaViewModel tarefaViewModel)
        {
            try
            {
                _tarefaRepositorio.Excluir(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(tarefaViewModel);
            }
        }
    }
}