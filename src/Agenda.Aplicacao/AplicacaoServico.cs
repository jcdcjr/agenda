using Agenda.Infra.Dados.Interfaces;

namespace Agenda.Aplicacao
{
    public class AplicacaoServico
    {
        private readonly IUnitOfWork _uow;

        public AplicacaoServico(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public void BeginTransaction()
        {
            _uow.BeginTransaction();
        }

        public void Commit()
        {
            _uow.Commit();
        }
    }
}