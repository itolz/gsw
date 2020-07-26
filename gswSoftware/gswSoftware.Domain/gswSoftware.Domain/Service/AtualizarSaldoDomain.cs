using gswSoftware.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;


namespace gswSoftware.Domain.Service
{
    public class AtualizarSaldoDomain : DomainBase, IAtualizarSaldoDomain
    {
        public void Execute(int id, int saldo)
        {
            provider.GetService<IClienteRepository>().AtualizarSaldo(id, saldo);
        }
    }
}
