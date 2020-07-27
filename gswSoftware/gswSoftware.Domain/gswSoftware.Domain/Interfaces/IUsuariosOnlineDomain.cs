using System;
using System.Collections.Generic;
using System.Text;

namespace gswSoftware.Domain.Interfaces
{
    public interface IUsuariosOnlineDomain
    {
        public int AddUser();

        public int CountUsers();

        public int RemoveUser(); 
    }
}
