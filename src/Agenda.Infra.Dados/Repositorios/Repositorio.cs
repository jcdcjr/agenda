using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Agenda.Dominio.Interfaces.Repositorios;
using Agenda.Infra.Dados.Context;

namespace Agenda.Infra.Dados.Repositorios
{
    public class Repositorio<TEntity>: IRepositorio<TEntity> where TEntity: class
    {
        protected AgendaContext Db;
        protected DbSet<TEntity> DbSet;

        public Repositorio(AgendaContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }


        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

        public TEntity Adicionar(TEntity obj)
        {
            var objReturn = DbSet.Add(obj);

            return objReturn;
        }

        public TEntity Atualizar(TEntity obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
            return obj;
        }

        public void Excluir(Guid id)
        {
            DbSet.Remove(ObterPorId(id));
        }

        public TEntity ObterPorId(Guid id)
        {
            return DbSet.Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return DbSet.ToList();
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public int Salvar()
        {
            return Db.SaveChanges();
        }
    }
}