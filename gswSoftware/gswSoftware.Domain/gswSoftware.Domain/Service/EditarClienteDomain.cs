using gswSoftware.Domain.Interfaces;
using gswSoftware.Domain.Models;
using Microsoft.Extensions.DependencyInjection;

namespace gswSoftware.Domain.Service
{
    public class EditarClienteDomain : DomainBase, IEditarClienteDomain
    {
        public void Execute(ClienteDomain cliente)
        {
            provider.GetService<IClienteRepository>().Editar(cliente.Id, cliente.Nome, cliente.Saldo);
        }
    }
}
