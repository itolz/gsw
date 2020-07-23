using System;
using System.Collections.Generic;
using System.Text;

namespace gswSoftware.Domain.Interfaces
{
    public interface IValidarSaldoDomain
    {
        public bool Execute(int IdCliente, int valorSolicitado);
    }
}
