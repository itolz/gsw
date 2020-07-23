using gswSoftware.Domain.Interfaces;
using System;
using Xunit;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Moq;
using gswSoftware.Domain.Models;
using System.Collections.Generic;

namespace gswSoftware.TDD
{
    public class DispensaNotasTDD : DomainTestBase
    {
        //[Fact]
        //public void DispensarNotas_100Reais()
        //{

        //    var service = provider.GetService<IDispensarNotasDomain>();

        //    var notasDispensadas = service.Execute(100);

        //    var somaValorNotasDispensadas = notasDispensadas.Sum(n => n.Valor);

        //    Assert.Equal(100, somaValorNotasDispensadas);
        //    Assert.Single(notasDispensadas); 
        //}
        [Theory]
        [InlineData(1010, 11)]
        [InlineData(1000, 10)]
        [InlineData(200, 2)]
        [InlineData(160, 3)]
        [InlineData(150, 2)]
        [InlineData(130, 3)]
        [InlineData(120, 2)]
        [InlineData(100, 1)]
        [InlineData(90, 3)]
        [InlineData(80, 3)]
        [InlineData(70, 2)]
        [InlineData(60, 2)]
        [InlineData(50, 1)]
        [InlineData(40, 2)]
        [InlineData(30, 2)]
        [InlineData(20, 1)]
        [InlineData(10, 1)]
        public void DispensarNotas(int valorSolicitado, int quantidadeNotasDispensadasEsperado)
        {

            var service = provider.GetService<IDispensarNotasDomain>();

            var notasDispensadas = service.Execute(valorSolicitado);

            var somaValorNotasDispensadas = notasDispensadas.Sum(n => n.Cedula);

            Assert.True(valorSolicitado == somaValorNotasDispensadas, string.Format("Somatoria Valor Solicitado ({0}) diferente da Somatoria do Valor das Notas Dispensadas", valorSolicitado));
            Assert.True(quantidadeNotasDispensadasEsperado == notasDispensadas.Count, string.Format("Quantidade de notas para o valor solicitado {0} nao corresponde ao esperado", valorSolicitado));

        }
    }
}
