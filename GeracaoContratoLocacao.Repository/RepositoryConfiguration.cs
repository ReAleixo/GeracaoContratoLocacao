using GeracaoContratoLocacao.Repository.Interfaces;
using GeracaoContratoLocacao.Repository.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace GeracaoContratoLocacao.Repository
{
    public static class RepositoryConfiguration
    {
        public static IServiceCollection RepositoryConfig(this IServiceCollection services)
        {
            services.AddSingleton<IHouseRepository, HouseRepository>();
            services.AddSingleton<IPeopleRepository, PeopleRepository>();

            return services;
        }
    }
}
