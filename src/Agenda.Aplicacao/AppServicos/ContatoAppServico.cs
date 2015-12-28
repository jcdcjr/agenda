using System;
using System.Collections.Generic;
using Agenda.Aplicacao.Interfaces;
using Agenda.Aplicacao.ViewModels;
using Agenda.Dominio.Entidades;
using Agenda.Dominio.Interfaces.Servicos;
using Agenda.Infra.Dados.Interfaces;
using AutoMapper;

namespace Agenda.Aplicacao.AppServicos
{
    public class ContatoAppServico: AplicacaoServico, IContatoAppServico
    {
        private readonly IContatoServico _contatoServico;

        public ContatoAppServico(IUnitOfWork uow, IContatoServico contatoServico) : base(uow)
        {
            _contatoServico = contatoServico;
        }

        public ContatoEnderecoTelefoneEmailViewModel Adicionar(
            ContatoEnderecoTelefoneEmailViewModel contatoEnderecoTelefoneEmailViewModel)
        {
            var contato =
                Mapper.Map<ContatoEnderecoTelefoneEmailViewModel, Contato>(contatoEnderecoTelefoneEmailViewModel);

            var endereco =
                Mapper.Map<ContatoEnderecoTelefoneEmailViewModel, Endereco>(contatoEnderecoTelefoneEmailViewModel);

            var telefone =
                Mapper.Map<ContatoEnderecoTelefoneEmailViewModel, Telefone>(contatoEnderecoTelefoneEmailViewModel);

            var email =
                Mapper.Map<ContatoEnderecoTelefoneEmailViewModel, Email>(contatoEnderecoTelefoneEmailViewModel);

            contato.Enderecos.Add(endereco);
            contato.Telefones.Add(telefone);
            contato.Emails.Add(email);

            BeginTransaction();
            _contatoServico.Adicionar(contato);
            Commit();

            return contatoEnderecoTelefoneEmailViewModel;
        }

        public ContatoViewModel Atualizar(ContatoViewModel contatoViewModel)
        {
            BeginTransaction();
            _contatoServico.Atualizar(Mapper.Map<ContatoViewModel, Contato>(contatoViewModel));
            Commit();

            return contatoViewModel;
        }

        public void Excluir(Guid id)
        {
            BeginTransaction();
               _contatoServico.Excluir(id);
            Commit();
        }

        public ContatoViewModel ObterPorId(Guid id)
        {
            return Mapper.Map<Contato, ContatoViewModel>(_contatoServico.ObterPorId(id));
        }

        public IEnumerable<ContatoViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<Contato>, IEnumerable<ContatoViewModel>>(_contatoServico.ObterTodos());
        }

        public IEnumerable<ContatoViewModel> ObterPorNome(string nome)
        {
            return Mapper.Map<IEnumerable<Contato>, IEnumerable<ContatoViewModel>>(_contatoServico.ObterPorNome(nome));
        }

        public void Dispose()
        {
            _contatoServico.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}