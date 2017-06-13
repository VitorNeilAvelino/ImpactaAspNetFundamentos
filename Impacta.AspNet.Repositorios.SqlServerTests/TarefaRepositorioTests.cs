﻿using System;
using Impacta.AspNet.Dominio;
using Impacta.AspNet.Repositorios.SqlServer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Impacta.AspNet.Repositorios.SqlServerTests
{
    [TestClass]
    public class TarefaRepositorioTests
    {
        private readonly TarefaRepositorio _tarefaRepositorio = new TarefaRepositorio();

        [TestMethod]
        public void InserirTest()
        {
            var tarefa = new Tarefa();
            tarefa.Nome = "Pagar cartão";
            tarefa.Prioridade = 3;
            tarefa.Concluida = false;
            tarefa.Observacoes = "Observações";

            var id = _tarefaRepositorio.Inserir(tarefa);

            Console.WriteLine(id);
        }

        [TestMethod]
        public void AtualizarTest()
        {
            var tarefa = new Tarefa();
            tarefa.Id = 2;
            tarefa.Nome = "Pagar cartão editado";
            tarefa.Prioridade = 0;
            tarefa.Concluida = true;
            tarefa.Observacoes = "Observações editado";

            _tarefaRepositorio.Atualizar(tarefa);
        }

        [TestMethod]
        public void SelecionarTeste()
        {
            var tarefas = _tarefaRepositorio.Selecionar();

            foreach (var tarefa in tarefas)
            {
                Console.WriteLine($"{tarefa.Id}|{tarefa.Nome}|{tarefa.Prioridade}|{tarefa.Concluida}|{tarefa.Observacoes}");
            }
        }

        [TestMethod]
        public void ExcluirTest()
        {
            _tarefaRepositorio.Excluir(1);

            var tarefa1 = _tarefaRepositorio.Selecionar(1);
            var tarefa2 = _tarefaRepositorio.Selecionar(2);

            Assert.IsNull(tarefa1);
            Assert.AreEqual(tarefa2.Nome, "Pagar cartão editado");
        }
    }
}