using gswSoftware.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace gswSoftware.Domain.Service
{
    public class ExcluirClienteDomain : DomainBase, IExcluirClienteDomain
    {
        public void Execute(int id)
        {
            provider.GetService<IClienteRepository>().Deletar(id); 
        }
    }
}
