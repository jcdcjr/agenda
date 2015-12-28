using Agenda.Aplicacao.AppServicos;
using Agenda.Aplicacao.Interfaces;
using Agenda.Dominio.Interfaces.Repositorios;
using Agenda.Dominio.Interfaces.Servicos;
using Agenda.Dominio.Servicos;
using Agenda.Infra.Dados.Context;
using Agenda.Infra.Dados.Interfaces;
using Agenda.Infra.Dados.Repositorios;
using Agenda.Infra.Dados.UnitOfWork;
using SimpleInjector;

namespace Agenda.Infra.Transversal.IoC
{
    public class Bootstraper
    {
        public static void RegisterServices(Container container)
        {
            //Aplicacao
            container.RegisterPerWebRequest<IContatoAppServico, ContatoAppServico>();

            //Dominio
            container.RegisterPerWebRequest<IContatoServico, ContatoServico>();

            //Infra.Dados
            container.RegisterPerWebRequest<IContatoRepositorio, ContatoRepositorio>();

            //Unit of Work
            container.RegisterPerWebRequest<IUnitOfWork, UnitOfWork>();

            //Context
            container.RegisterPerWebRequest<AgendaContext>();
        }
    }
}