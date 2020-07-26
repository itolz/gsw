using gswSoftware.Domain.Interfaces;
using gswSoftware.Domain.Service;
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
            services.AddSingleton<IInitializeDomain, InitializeDomain>();
            services.AddScoped<IAtualizarSaldoDomain, AtualizarSaldoDomain>();
            services.AddScoped<IDispensarNotasDomain, DispensarNotasDomain>();
            services.AddScoped<IInserirClienteDomain, InserirClienteDomain>();
            services.AddScoped<IListarClientesDomain, ListarClientesDomain>();
            services.AddScoped<IOperarSaqueDomain, OperarSaqueDomain>();
            services.AddScoped<ISelecionarCliente, SelecionarCliente>();
            services.AddScoped<IValidarSaldoDomain, ValidarSaldoDomain>();
            services.AddScoped<IValidarSaldoDomain, ValidarSaldoDomain>();
            services.AddScoped<IExcluirClienteDomain, ExcluirClienteDomain>();
            services.AddScoped<IEditarClienteDomain, EditarClienteDomain>();

            return services;
        }
    }
}
