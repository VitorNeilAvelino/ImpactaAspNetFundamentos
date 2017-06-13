﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Impacta.AspNet.Dominio;

namespace AspNetFundamentos.Capitulo07.AcessoDados.Models
{
    public class TarefaViewModel
    {
        public TarefaViewModel()
        {

        }

        public TarefaViewModel(Tarefa tarefa)
        {
            // Substituir por alguma biblioteca de mapeamento (Automapper, TinyMapper etc).
            Id = tarefa.Id;
            Nome = tarefa.Nome;
            Prioridade = tarefa.Prioridade;
            Concluida = tarefa.Concluida;
            Observacoes = tarefa.Observacoes;
        }

        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        [Range(0, 3)]
        public int Prioridade { get; set; }

        [Required]
        [DisplayName("Concluída")]
        public bool Concluida { get; set; }

        [Display(Name = "Observações")]
        public string Observacoes { get; set; }
    }
}