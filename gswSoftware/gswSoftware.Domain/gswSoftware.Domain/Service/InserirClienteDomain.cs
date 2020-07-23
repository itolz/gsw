using gswSoftware.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;


namespace gswSoftware.Domain.Service
{
    public class InserirClienteDomain : DomainBase, IInserirClienteDomain
    {
        public void Execute(string nome, int Saldo)
        {
            provider.GetService<IClienteRepository>().Insert(nome, Saldo);
        }
    }
}
