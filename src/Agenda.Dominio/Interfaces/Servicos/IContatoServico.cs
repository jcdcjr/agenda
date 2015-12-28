using System;
using System.Collections.Generic;
using Agenda.Dominio.Entidades;

namespace Agenda.Dominio.Interfaces.Servicos
{
    public interface IContatoServico: IDisposable
    {
        Contato Adicionar(Contato contato);
        Contato Atualizar(Contato contato);
        void Excluir(Guid id);
        Contato ObterPorId(Guid id);
        IEnumerable<Contato> ObterTodos();
        IEnumerable<Contato> ObterPorNome(string nome);
    }
}