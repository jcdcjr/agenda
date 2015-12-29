using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Agenda.Aplicacao.ViewModels
{
    public class EnderecoViewModel
    {
        public EnderecoViewModel()
        {
            EnderecoId = Guid.NewGuid();
        }

        [Key]
        public Guid EnderecoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo CEP.")]
        [MaxLength(8, ErrorMessage = "O campo CEP conter {0} caracteres.")]
        [MinLength(8, ErrorMessage = "O campo CEP conter {0} caracteres.")]
        [DisplayName("CEP *")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Preencha o campo Logradouro.")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres.")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres.")]
        [DisplayName("Logradouro *")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Preencha o campo Número.")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres.")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres.")]
        [DisplayName("Número *")]
        public string Numero { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "Preencha o campo Bairro.")]
        [MaxLength(80, ErrorMessage = "Máximo {0} caracteres.")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres.")]
        [DisplayName("Bairro *")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Preencha o campo Cidade.")]
        [MaxLength(80, ErrorMessage = "Máximo {0} caracteres.")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres.")]
        [DisplayName("Cidade *")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Preencha o campo Estado.")]
        [MaxLength(2, ErrorMessage = "Máximo {0} caracteres.")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres.")]
        [DisplayName("Estado *")]
        public string Estado { get; set; } 
    }
}