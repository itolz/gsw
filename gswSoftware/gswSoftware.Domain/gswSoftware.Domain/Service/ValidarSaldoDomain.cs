using gswSoftware.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;


namespace gswSoftware.Domain.Service
{
    public class ValidarSaldoDomain : DomainBase, IValidarSaldoDomain
    {
        public bool Execute(int IdCliente, int valorSolicitado)
        {
            var cliente = provider.GetService<ISelecionarClienteDomain>().Execute(IdCliente);

                return cliente.Saldo >= valorSolicitado;
        }
    }
}
