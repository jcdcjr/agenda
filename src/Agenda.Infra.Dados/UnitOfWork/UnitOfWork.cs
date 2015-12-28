using System;
using Agenda.Infra.Dados.Context;
using Agenda.Infra.Dados.Interfaces;

namespace Agenda.Infra.Dados.UnitOfWork
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly AgendaContext _context;
        private bool _disposed;

        public UnitOfWork(AgendaContext context)
        {
            _context = context;
        }

        public void BeginTransaction()
        {
            _disposed = false;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}