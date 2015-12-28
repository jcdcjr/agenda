using Agenda.Aplicacao.ViewModels;
using Agenda.Dominio.Entidades;
using AutoMapper;

namespace Agenda.Aplicacao.AutoMapper
{
    public class DominioParaViewModelsMappings: Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Contato, ContatoEnderecoTelefoneEmailViewModel>();
            Mapper.CreateMap<Endereco, ContatoEnderecoTelefoneEmailViewModel>();
            Mapper.CreateMap<Telefone, ContatoEnderecoTelefoneEmailViewModel>();
            Mapper.CreateMap<Email, ContatoEnderecoTelefoneEmailViewModel>();

            Mapper.CreateMap<Contato, ContatoViewModel>();
            Mapper.CreateMap<Endereco, EnderecoViewModel>();
            Mapper.CreateMap<Telefone, TelefoneViewModel>();
            Mapper.CreateMap<Email, EmailViewModel>();
        }
    }
}