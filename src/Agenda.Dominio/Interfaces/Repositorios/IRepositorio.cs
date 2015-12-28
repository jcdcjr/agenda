using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Agenda.Dominio.Interfaces.Repositorios
{
    public interface IRepositorio<TEntity>: IDisposable where TEntity: class
    {
        TEntity Adicionar(TEntity obj);
        TEntity Atualizar(TEntity obj);
        void Excluir(Guid id);
        TEntity ObterPorId(Guid id);
        IEnumerable<TEntity> ObterTodos();
        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);
        int Salvar();
    }
}