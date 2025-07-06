using GeracaoContratoLocacao.Repository.Interfaces;
using GeracaoContratoLocacao.Repository.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeracaoContratoLocacao.Repository.Configuration
{
    public static class RepositoryConfiguration
    {
        public static IServiceCollection RepositoryConfig(this IServiceCollection services)
        {
            services.AddSingleton<IHouseRepository, HouseRepository>();

            return services;
        }
    }
}
