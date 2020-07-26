using gswSoftware.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace gswSoftware.Domain.Interfaces
{
    public interface IClienteRepository
    {
        public IEnumerable<ClienteDomain> ListarPublico();
        public IEnumerable<ClienteDomain> Listar();

        public ClienteDomain Selecionar(int Id);
        public ClienteDomain Login(string UserName, string Password);

        public int AtualizarSaldo(int Id, int saldo);

        public int Editar(int Id, string nome, int saldo);

        public int Insert(string nome, int saldo);

        public int Deletar(int Id);

    }
}
