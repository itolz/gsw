using gswSoftware.Domain.Interfaces;
using gswSoftware.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace gswSoftware.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : WebApiControllerBase
    {
        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public ClienteDomain Authenticate([FromBody]ClienteDomain cliente)
        {

            var clienteRetornado = GetService<ISelecionarClienteDomain>().Execute(cliente.UserName, cliente.Password);

            if (clienteRetornado != null)
            {
                var token = provider.GetService<ITokenDomain>().GenerateToken(clienteRetornado);
                clienteRetornado.Token = token;

            }

            return clienteRetornado;
        }

        public AccountController()
        {
           
        }
    }
}
