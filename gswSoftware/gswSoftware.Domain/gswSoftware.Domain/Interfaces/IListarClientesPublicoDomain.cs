using gswSoftware.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace gswSoftware.Domain.Interfaces
{
    public interface IListarClientesPublicoDomain
    {
        List<ClienteDomain> Execute();
    }
}
