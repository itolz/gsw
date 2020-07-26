using gswSoftware.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace gswSoftware.Domain.Interfaces
{
    public interface ISelecionarClienteDomain
    {
        public ClienteDomain Execute(int Id);

        public ClienteDomain Execute(string UserName, string Password);
    }
}
