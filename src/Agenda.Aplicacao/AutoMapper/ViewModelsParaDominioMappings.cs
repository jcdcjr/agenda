using Agenda.Aplicacao.ViewModels;
using Agenda.Dominio.Entidades;
using AutoMapper;

namespace Agenda.Aplicacao.AutoMapper
{
    public class ViewModelsParaDominioMappings: Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<ContatoEnderecoTelefoneEmailViewModel, Contato>();
            Mapper.CreateMap<ContatoEnderecoTelefoneEmailViewModel, Endereco>();
            Mapper.CreateMap<ContatoEnderecoTelefoneEmailViewModel, Telefone>();
            Mapper.CreateMap<ContatoEnderecoTelefoneEmailViewModel, Email>();

            Mapper.CreateMap<ContatoViewModel, Contato>();
            Mapper.CreateMap<EnderecoViewModel, Endereco>();
            Mapper.CreateMap<TelefoneViewModel, Telefone>();
            Mapper.CreateMap<EmailViewModel, Email>();
        }
    }
}