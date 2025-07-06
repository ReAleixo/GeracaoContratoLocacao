using GeracaoContratoLocacao.Presentation.Configurations;
using GeracaoContratoLocacao.Service.Configuration;
using Microsoft.Extensions.DependencyInjection;
using static System.Net.Mime.MediaTypeNames;

namespace GeracaoContratoLocacao.Presentation
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var serviceProvider = ConfigureDependencyInjection(new ServiceCollection());
            Application.Run(new Menu(serviceProvider));
        }

        public static ServiceProvider ConfigureDependencyInjection(IServiceCollection services)
        {
            services.ControllerConfig();
            services.ServiceConfig();

            return services.BuildServiceProvider();
        }
    }
}