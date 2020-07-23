using gswSoftware.Domain.Interfaces;
using System;
using Xunit;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace gswSoftware.TDD
{
    public class SaquesTDD : DomainTestBase
    {
        [Fact]
        public void SacarMontante_100Reais()
        {
            var service = provider.GetService<ISacarMontanteDomain>();
            var notasDispensadas = service.Execute(100);

            var somaValorDispensado = notasDispensadas.Sum(notaDispensada => notaDispensada.Valor);

            Assert.True(1 == notasDispensadas.Count, "Quantidade de Notas dispensadas invalido");
            Assert.True(100 == somaValorDispensado, "Valor dispensada diferente do solicitado");
        }
    }
}
