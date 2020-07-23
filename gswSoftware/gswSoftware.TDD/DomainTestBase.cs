using gswSoftware.Domain;
using gswSoftware.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace gswSoftware.TDD
{
    public class DomainTestBase
    {
        public ServiceProvider provider { get; set; }
        public DomainTestBase()
        {
            var service = new ServiceCollection();

            service.AddDomainServiceCollection();

            provider = service.BuildServiceProvider();

            provider.GetService<IInitializeDomain>().Initialize(provider);
        }
    }
}
