using gswSoftware.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using gswSoftware.Domain.Models;

namespace gswSoftware.Domain.Service
{
    public class InserirClienteDomain : DomainBase, IInserirClienteDomain
    {
        public void Execute(ClienteDomain cliente)
        {
            provider.GetService<IClienteRepository>().Insert(cliente.Nome, cliente.Saldo, cliente.Role, cliente.UserName, cliente.Password);
        }
    }
}
