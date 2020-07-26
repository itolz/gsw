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
        public void InserirCliente(ClienteDomain cliente)
        {
            GetService<IInserirClienteDomain>().Execute(cliente);
        }

        [HttpPut("EditarCliente")]
        public void EditarCliente(ClienteDomain cliente)
        {
            GetService<IEditarClienteDomain>().Execute(cliente);
        }


        [HttpDelete("ExcluirCliente/{id}")]
        public void ExcluirCliente(int id)
        {
            GetService<IExcluirClienteDomain>().Execute(id);
        }
    }
}
