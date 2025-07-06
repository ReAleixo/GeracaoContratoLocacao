using GeracaoContratoLocacao.Presentation.Configurations;
using GeracaoContratoLocacao.Service.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GeracaoContratoLocacao.Presentation
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var serviceProvider = ConfigureDependencyInjection(new ServiceCollection());
            Application.Run(new FormularioContrato(serviceProvider));
        }

        public static ServiceProvider ConfigureDependencyInjection(IServiceCollection services)
        {
            services.ControllerConfig();
            services.ServiceConfig();

            return services.BuildServiceProvider();
        }
    }
}