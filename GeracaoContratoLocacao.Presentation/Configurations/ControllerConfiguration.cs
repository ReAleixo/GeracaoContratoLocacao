using GeracaoContratoLocacao.Presentation.Controllers;
using GeracaoContratoLocacao.Presentation.Interfaces;
using GeracaoContratoLocacao.Service.Interfaces;
using GeracaoContratoLocacao.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GeracaoContratoLocacao.Presentation.Configurations
{
    public class ControllerConfiguration
    {
        public static ServiceProvider Configure()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IFormularioContratoController, FormularioContratoController>();
            services.AddSingleton<IHouseController, ImovelController>();
            services.AddSingleton<IGeracaoContratoService, GeracaoContratoService>();

            return services.BuildServiceProvider();
        }
    }
}
