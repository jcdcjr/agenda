using System;
using System.Collections.Generic;
using Agenda.Dominio.Entidades;
using Agenda.Dominio.Interfaces.Repositorios;
using Agenda.Dominio.Interfaces.Servicos;

namespace Agenda.Dominio.Servicos
{
    public class ContatoServico: IContatoServico
    {
        private readonly IContatoRepositorio _contatoRepositorio;

        public ContatoServico(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }

        public void Dispose()
        {
            _contatoRepositorio.Dispose();
        }

        public Contato Adicionar(Contato contato)
        {
            return _contatoRepositorio.Adicionar(contato);
        }

        public Contato Atualizar(Contato contato)
        {
            return _contatoRepositorio.Atualizar(contato);
        }

        public void Excluir(Guid id)
        {
            _contatoRepositorio.Excluir(id);
        }

        public Contato ObterPorId(Guid id)
        {
            return _contatoRepositorio.ObterPorId(id);
        }

        public IEnumerable<Contato> ObterTodos()
        {
            return _contatoRepositorio.ObterTodos();
        }

        public IEnumerable<Contato> ObterPorNome(string nome)
        {
            return _contatoRepositorio.ObterPorNome(nome);
        }
    }
}