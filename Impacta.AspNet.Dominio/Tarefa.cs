﻿namespace Impacta.AspNet.Dominio
{
    //Página 338.
    public class Tarefa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Prioridade Prioridade { get; set; }
        public bool Concluida { get; set; }
        public string Observacoes { get; set; }
    }
}