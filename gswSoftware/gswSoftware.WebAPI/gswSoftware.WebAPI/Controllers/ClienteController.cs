using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using gswSoftware.Domain.Interfaces;
using gswSoftware.Domain.Models;
using Microsoft.AspNetCore.Authorization;

namespace gswSoftware.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : WebApiControllerBase
    {
        [HttpGet("ListarClientes")]
        [Authorize]
        public List<ClienteDomain> ListarClientes()
        {
            return GetService<IListarClientesDomain>().Execute();
        }

        [HttpGet("ListarClientesPublico")]
        [AllowAnonymous]
        public List<ClienteDomain> ListarClientesPublico()
        {
            return GetService<IListarClientesPublicoDomain>().Execute();
        }

        [HttpPut("AtualizarSaldo")]
        [AllowAnonymous]
        public void AtualizarSaldo(int Id, int Saldo)
        {
            GetService<IAtualizarSaldoDomain>().Execute(Id, Saldo);
        }

        [HttpPost("InserirCliente")]
        [Authorize(Roles = "admin")]

        public void InserirCliente(ClienteDomain cliente)
        {
            GetService<IInserirClienteDomain>().Execute(cliente);
        }

        [HttpPut("EditarCliente")]
        [Authorize(Roles = "admin")]

        public void EditarCliente(ClienteDomain cliente)
        {
            GetService<IEditarClienteDomain>().Execute(cliente);
        }


        [HttpDelete("ExcluirCliente/{id}")]
        [Authorize(Roles = "admin")]

        public void ExcluirCliente(int id)
        {
            GetService<IExcluirClienteDomain>().Execute(id);
        }
    }
}
