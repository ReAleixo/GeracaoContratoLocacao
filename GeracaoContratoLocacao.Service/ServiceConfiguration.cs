using GeracaoContratoLocacao.Service.Interfaces;
using GeracaoContratoLocacao.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GeracaoContratoLocacao.Service
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection ServiceConfig(this IServiceCollection services)
        {
            services.AddSingleton<IContratoService, GeracaoContratoService>();
            services.AddSingleton<IImovelService, ImovelService>();
            services.AddSingleton<IPessoaService, PessoaService>();

            return services;
        }
    }
}
