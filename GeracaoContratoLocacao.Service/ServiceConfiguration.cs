using GeracaoContratoLocacao.Service.Interfaces;
using GeracaoContratoLocacao.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GeracaoContratoLocacao.Service
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection ServiceConfig(this IServiceCollection services)
        {
            services.AddSingleton<IGeracaoContratoService, GeracaoContratoService>();
            services.AddSingleton<IImovelService, ImovelService>();
            services.AddSingleton<IPeopleService, PeopleService>();

            return services;
        }
    }
}
