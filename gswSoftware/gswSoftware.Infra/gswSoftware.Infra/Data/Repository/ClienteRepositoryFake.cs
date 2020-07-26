using gswSoftware.Domain.Interfaces;
using gswSoftware.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gswSoftware.Infra.Data.Repository
{
    internal class ClienteRepositoryFake : IClienteRepository
    {
        public int Deletar(int Id)
        {
            return 0; 
        }

        public int Insert(string nome, int saldo)
        {
            return 0;
        }

        public IEnumerable<ClienteDomain> Listar()
        {
            List<ClienteDomain> listaDomain = new List<ClienteDomain>();
            listaDomain.Add(new ClienteDomain { Id = 1, Nome = "Aline", Saldo = 800 });
            listaDomain.Add(new ClienteDomain { Id = 2, Nome = "Laura", Saldo = 30 });
            listaDomain.Add(new ClienteDomain { Id = 3, Nome = "Sofia", Saldo = 130 });

            return listaDomain;

        }

        public ClienteDomain Selecionar(int Id)
        {
            return Listar().Where(c => c.Id == Id).FirstOrDefault(); 
        }

        public int AtualizarSaldo(int Id, int saldo)
        {
            return Selecionar(Id).Saldo - saldo;
        }

        public int Editar(int Id, string nome, int saldo)
        {
            return 0; 
        }
    }
}
