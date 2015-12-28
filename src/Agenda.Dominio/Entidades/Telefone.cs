using System;

namespace Agenda.Dominio.Entidades
{
    public class Telefone
    {
        public Telefone()
        {
            TelefoneId = Guid.NewGuid();
        }

        public Guid TelefoneId{ get; set; }
        public TipoTelefone TipoTelefone { get; set; }
        public string Fone { get; set; }
        public string Ramal { get; set; }

        public Guid ContatoId { get; set; }

        public virtual Contato Contato { get; set; }
    }
}