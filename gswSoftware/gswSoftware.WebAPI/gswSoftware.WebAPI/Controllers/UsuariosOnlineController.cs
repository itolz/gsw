using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using gswSoftware.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace gswSoftware.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosOnlineController : WebApiControllerBase
    {
        private readonly IUsuariosOnlineDomain _usuariosOnlineDomain;

        public UsuariosOnlineController(IUsuariosOnlineDomain usuariosOnlineDomain)
        {
            _usuariosOnlineDomain = usuariosOnlineDomain;
        }

        [HttpGet("UsuariosOnline")]
        [AllowAnonymous]
        public int UsuariosOnline()
        {
            return _usuariosOnlineDomain.CountUsers();
        }

        [HttpGet("AdicionarUsuario")]
        [AllowAnonymous]
        public int  AdicionarUsuario()
        {
            return _usuariosOnlineDomain.AddUser();
        }

        [HttpGet("RemoverUsuario")]
        [AllowAnonymous]
        public int RemoverUsuario()
        {
           return _usuariosOnlineDomain.RemoveUser();
        }
    }
}
