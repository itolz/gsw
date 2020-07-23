using gswSoftware.Domain.Interfaces;
using gswSoftware.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace gswSoftware.Domain.Service
{
    public class SelecionarCliente : DomainBase, ISelecionarCliente
    {
        public ClienteDomain Execute(int Id)
        {
            return provider.GetService<IClienteRepository>().Selecionar(Id);
        }
    }
}
