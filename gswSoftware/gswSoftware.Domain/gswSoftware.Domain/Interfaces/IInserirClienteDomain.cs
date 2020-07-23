using System;
using System.Collections.Generic;
using System.Text;

namespace gswSoftware.Domain.Interfaces
{
    public interface IInserirClienteDomain
    {
        public void Executar(string Nome, int Saldo);
    }
}
