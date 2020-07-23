﻿using gswSoftware.Domain.Interfaces;
using gswSoftware.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace gswSoftware.Domain.Service
{
    public class ListarClientesDomain : DomainBase,  IListarClientesDomain
    {
        public List<ClienteDomain> Execute()
        {
            return provider.GetService<IClienteRepository>().Listar().ToList();
        }
    }
}
