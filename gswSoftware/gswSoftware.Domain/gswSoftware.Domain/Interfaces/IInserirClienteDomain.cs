using System;
using System.Collections.Generic;
using System.Text;

namespace gswSoftware.Domain.Interfaces
{
    public interface IInserirClienteDomain
    {
        public void Execute(string Nome, int Saldo);
    }
}
