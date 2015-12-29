using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Agenda.Dominio.Entidades;

namespace Agenda.Aplicacao.ViewModels
{
    public class ContatoEnderecoTelefoneEmailViewModel
    {
        public ContatoEnderecoTelefoneEmailViewModel()
        {
            ContatoId = Guid.NewGuid();

            Enderecos = new List<EnderecoViewModel>();
            Telefones = new List<TelefoneViewModel>();
            Emails = new List<EmailViewModel>();
        }

        [Key]
        public Guid ContatoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome.")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres.")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres.")]
        [DisplayName("Nome *")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Sobrenome.")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres.")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres.")]
        [DisplayName("Sobrenome *")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Informe a Data de Nascimento.")]
        [DataType(DataType.Date)]
        [DisplayName("Data de Nascimento *")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Informe o Sexo.")]
        [DisplayName("Sexo *")]
        public Sexo Sexo { get; set; }

        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public ICollection<EnderecoViewModel> Enderecos { get; set; }
        public ICollection<TelefoneViewModel> Telefones { get; set; }
        public ICollection<EmailViewModel> Emails { get; set; }
    }
}