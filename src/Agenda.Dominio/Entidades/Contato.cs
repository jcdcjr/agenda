using System;
using System.Collections.Generic;

namespace Agenda.Dominio.Entidades
{
    public class Contato
    {
        public Contato()
        {
            ContatoId = Guid.NewGuid();

            Enderecos = new List<Endereco>();
            Telefones = new List<Telefone>();
            Emails = new List<Email>();
        }

        public Guid ContatoId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Sexo Sexo { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }

        public virtual  ICollection<Endereco> Enderecos  { get; set; }
        public virtual ICollection<Telefone> Telefones  { get; set; }
        public virtual ICollection<Email> Emails  { get; set; }
    }
}