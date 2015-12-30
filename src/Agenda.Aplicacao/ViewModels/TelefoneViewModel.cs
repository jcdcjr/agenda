using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Agenda.Dominio.Entidades;

namespace Agenda.Aplicacao.ViewModels
{
    public class TelefoneViewModel
    {
        public TelefoneViewModel()
        {
            TelefoneId = Guid.NewGuid();
        }

        [Key]
        public Guid TelefoneId { get; set; }

        [Required(ErrorMessage = "Informe o Tipo de Telefone")]
        [DisplayName("Tipo de Telefone *")]
        public TipoTelefone TipoTelefone { get; set; }

        [Required(ErrorMessage = "Preencha o campo Telefone.")]
        [MaxLength(16, ErrorMessage = "Máximo {0} caracteres.")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres.")]
        [DisplayName("Número *")]
        public string Fone { get; set; }

        [MaxLength(4, ErrorMessage = "Máximo {0} caracteres.")]
        public string Ramal { get; set; } 
    }
}