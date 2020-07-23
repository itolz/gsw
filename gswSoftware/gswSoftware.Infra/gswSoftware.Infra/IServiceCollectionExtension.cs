using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;


namespace gswSoftware.Infra
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddInfraServiceCollection(this IServiceCollection services)
        {
            //services.AddScoped<interface, Class>();

            return services; 
        }
    }
}
