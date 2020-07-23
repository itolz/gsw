using gswSoftware.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace gswSoftware.Domain.Interfaces
{
    public interface IListarClientesDomain
    {
        public List<ClienteDomain> Execute(); 
    }
}
