using AutoMapper;

namespace Agenda.Aplicacao.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DominioParaViewModelsMappings>();
                x.AddProfile<ViewModelsParaDominioMappings>();
            });
        }
    }
}