using System;

namespace Agenda.Dominio.Entidades
{
    public class Email
    {
        public Email()
        {
            EmailId = Guid.NewGuid();
        }

        public Guid EmailId { get; set; }
        public TipoEmail TipoEmail { get; set; }
        public string Mail { get; set; }

        public Guid ContatoId { get; set; }

        public virtual  Contato Contato { get; set; }
    }
}