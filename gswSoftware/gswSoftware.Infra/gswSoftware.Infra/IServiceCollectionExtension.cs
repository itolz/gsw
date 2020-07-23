using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using gswSoftware.Infra.Data.Repository;
using gswSoftware.Domain.Interfaces;

namespace gswSoftware.Infra
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddInfraServiceCollection(this IServiceCollection services)
        {
            services.AddScoped<IClienteRepository, ClienteRepositoryFake>();

            return services; 
        }
    }
}
