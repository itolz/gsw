using gswSoftware.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace gswSoftware.Domain.Service
{
    public class UsuariosOnlineDomain : IUsuariosOnlineDomain
    {
        private int ControleUsuariosOnline;
        public UsuariosOnlineDomain()
        {
            ControleUsuariosOnline = 0;
        }
        public int AddUser()
        {
            int retorno = -1;
            if (ControleUsuariosOnline < 5)
            {
                ControleUsuariosOnline++;
                retorno = ControleUsuariosOnline;

            }

            return retorno;
        }

        public int CountUsers()
        {
            return ControleUsuariosOnline;
        }

        public int RemoveUser()
        {
            ControleUsuariosOnline--;

            return ControleUsuariosOnline;
        }
    }
}
