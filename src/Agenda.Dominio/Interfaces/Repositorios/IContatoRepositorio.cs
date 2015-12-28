using System.Collections.Generic;
using Agenda.Dominio.Entidades;

namespace Agenda.Dominio.Interfaces.Repositorios
{
    public interface IContatoRepositorio: IRepositorio<Contato>
    {
        IEnumerable<Contato> ObterPorNome(string nome);
    }
}