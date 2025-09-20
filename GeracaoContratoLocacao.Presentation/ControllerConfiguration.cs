using GeracaoContratoLocacao.Presentation.Controllers;
using GeracaoContratoLocacao.Presentation.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace GeracaoContratoLocacao.Presentation
{
    public static class ControllerConfiguration
    {
        public static IServiceCollection ControllerConfig(this IServiceCollection services)
        {
            services.AddSingleton<IFormularioContratoController, FormularioContratoController>();
            services.AddSingleton<IHouseController, ImovelController>();
            services.AddSingleton<IPeopleController, PeopleController>();

            return services;
        }
    }
}
