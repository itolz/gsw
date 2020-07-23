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
    public class ClientesTDD 
    {
        [Fact]
        public void ListarClientes()
        {
            List<ClienteDomain> listaDomain = new List<ClienteDomain>();
            listaDomain.Add(new ClienteDomain {Id =1, Nome = "Aline", Saldo= 800 });
            listaDomain.Add(new ClienteDomain {Id =1, Nome = "Laura", Saldo= 30 });
            listaDomain.Add(new ClienteDomain {Id =1, Nome = "Sofia", Saldo= 130 });

            var ServiceClientesRepo = new Mock<IListarClientesDomain>();
            ServiceClientesRepo.Setup(x => x.Execute()).Returns(listaDomain);


            var listaClientes = ServiceClientesRepo.Object.Execute(); 


            Assert.Equal(3, listaClientes.Count);
            
        }
    }
}
