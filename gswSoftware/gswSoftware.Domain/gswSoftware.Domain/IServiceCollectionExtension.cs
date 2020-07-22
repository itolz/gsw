using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace gswSoftware.Domain
{
    public static class IServiceCollectionExtension
    {
        //***  container de injeção de dependência ***
        public static IServiceCollection AddDomainServiceCollection(this IServiceCollection services)
        {
            //services.AddScoped<interface, Class>();

            return services;
        }
    }
}
