using gswSoftware.Domain.Interfaces;
using gswSoftware.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace gswSoftware.Domain.Service
{
    public class SelecionarClienteDomain : DomainBase, ISelecionarClienteDomain
    {
        public ClienteDomain Execute(int Id)
        {
            return provider.GetService<IClienteRepository>().Selecionar(Id);
        }

        public ClienteDomain Execute(string UserName, string Password)
        {

            var login =  provider.GetService<IClienteRepository>().Login(UserName, Password);

            return login; 
        }
    }
}
