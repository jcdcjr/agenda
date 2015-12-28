using System;
using System.Collections.Generic;
using Agenda.Aplicacao.ViewModels;

namespace Agenda.Aplicacao.Interfaces
{
    public interface IContatoAppServico: IDisposable
    {
        ContatoEnderecoTelefoneEmailViewModel Adicionar(ContatoEnderecoTelefoneEmailViewModel contatoEnderecoTelefoneEmailViewModel);
        ContatoViewModel Atualizar(ContatoViewModel contatoViewModel);
        void Excluir(Guid id);
        ContatoViewModel ObterPorId(Guid id);
        IEnumerable<ContatoViewModel> ObterTodos();
        IEnumerable<ContatoViewModel> ObterPorNome(string nome);
    }
}