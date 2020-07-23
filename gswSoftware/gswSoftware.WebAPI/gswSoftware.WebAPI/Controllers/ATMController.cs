using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using gswSoftware.Domain.Models;
using gswSoftware.Domain.Interfaces;

namespace gswSoftware.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ATMController : WebApiControllerBase
    {
        [HttpGet("OperarSaque")]
        public RetornoOperacaoDomain OperarSaque(int idUsuario, int valorSolicitado)
        {
            return GetService<IOperarSaqueDomain>().Execute(idUsuario, valorSolicitado);
        }

        [HttpGet]
        public string Get()
        {
            return "GSW Accessement";
        }
    }
}
