using gswSoftware.Domain.Interfaces;
using NUnit.Framework;
using System.Security.Cryptography;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace gswSoftware.Test
{
    public class SaqueTest : DomainTestBase
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidarSaque()
        {
            var service = provider.GetService<ISacarMontanteDomain>();

            var notasDispensadas = service.Execute(100);


            var somaValorDispensado = notasDispensadas.Sum(s => s.Valor);

            Assert.AreEqual(1, notasDispensadas.Count, "Quantidade de notas nao satisfatorio");
            Assert.AreEqual(100, somaValorDispensado, "Soma do valor dispensado e diferente do solicitado");

        }
    }
}