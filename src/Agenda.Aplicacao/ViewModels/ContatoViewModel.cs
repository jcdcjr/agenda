using System;
using Agenda.Dominio.Entidades;

namespace Agenda.Aplicacao.ViewModels
{
    public class ContatoViewModel
    {
        public ContatoViewModel()
        {
            ContatoId = Guid.NewGuid();
        }

        public Guid ContatoId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Sexo Sexo { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}