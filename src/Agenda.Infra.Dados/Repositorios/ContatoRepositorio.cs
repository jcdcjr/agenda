using System.Collections.Generic;
using Agenda.Dominio.Entidades;
using Agenda.Dominio.Interfaces.Repositorios;
using Agenda.Infra.Dados.Context;

namespace Agenda.Infra.Dados.Repositorios
{
    public class ContatoRepositorio : Repositorio<Contato>, IContatoRepositorio
    {
        public ContatoRepositorio(AgendaContext context) : base(context)
        {
        }

        public IEnumerable<Contato> ObterPorNome(string nome)
        {
            return Buscar(c => c.Nome.Contains(nome));
        }
    }
}