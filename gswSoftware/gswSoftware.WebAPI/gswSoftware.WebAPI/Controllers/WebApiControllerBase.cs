using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gswSoftware.Domain;
using gswSoftware.Domain.Interfaces;
using gswSoftware.Infra;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace gswSoftware.WebAPI.Controllers
{

    public class WebApiControllerBase : ControllerBase
    {
        public ServiceProvider provider { get; private set; }
        public WebApiControllerBase()
        {
            var service = new ServiceCollection();
            service.AddDomainServiceCollection();
            service.AddInfraServiceCollection();
            

            provider = service.BuildServiceProvider(); 
            
        }

        public T GetService<T>()
        {
            provider.GetService<IInitializeDomain>().Initialize(provider);
            return provider.GetService<T>();
        }
    }
}
