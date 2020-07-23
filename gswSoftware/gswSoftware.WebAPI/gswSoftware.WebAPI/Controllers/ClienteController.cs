using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using gswSoftware.Domain.Interfaces;
using gswSoftware.Domain.Models;

namespace gswSoftware.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : WebApiControllerBase
    {
        [HttpGet("ListarClientes")]
        public List<ClienteDomain> ListarClientes()
        {
            return GetService<IListarClientesDomain>().Execute();
        }

        [HttpPut("AtualizarSaldo")]
        public void AtualizarSaldo(int Id, int Saldo)
        {
            GetService<IAtualizarSaldoDomain>().Execute(Id, Saldo);
        }

        [HttpPost("InserirCliente")]
        public void InserirCliente(string Nome, int Saldo)
        {
            GetService<IInserirClienteDomain>().Execute(Nome, Saldo);
        }
    }
}
