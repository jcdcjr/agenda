using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Agenda.Dominio.Entidades;

namespace Agenda.Aplicacao.ViewModels
{
    public class EmailViewModel
    {
        public EmailViewModel()
        {
            EmailId = Guid.NewGuid();
        }

        [Key]
        public Guid EmailId { get; set; }

        [Required(ErrorMessage = "Informe o Tipo de E-mail")]
        [DisplayName("Tipo de E-Mail *")]
        public TipoEmail TipoEmail { get; set; }

        [Required(ErrorMessage = "Preencha o Campo E-Mail.")]
        [EmailAddress(ErrorMessage = "Informe um e-mail válido.")]
        [DisplayName("E-Mail *")]
        public string Mail { get; set; }
        
    }
}