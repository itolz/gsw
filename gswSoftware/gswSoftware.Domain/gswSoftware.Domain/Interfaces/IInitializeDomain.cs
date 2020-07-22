using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace gswSoftware.Domain.Interfaces
{
    public interface IInitializeDomain
    {
        void Initialize(ServiceProvider _provider);
    }
}
