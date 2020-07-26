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
            listaDomain.Add(new ClienteDomain { Id = 1, Nome = "Aline Bretas", Saldo = 800, UserName="aline", Password="cliente123", Role="cliente" });
            listaDomain.Add(new ClienteDomain { Id = 2, Nome = "Laura Bretas", Saldo = 30, UserName = "laura", Password = "cliente123", Role = "cliente" });
            listaDomain.Add(new ClienteDomain { Id = 3, Nome = "Sofia Bretas", Saldo = 130, UserName = "sofia", Password = "cliente123", Role = "cliente" });
            listaDomain.Add(new ClienteDomain { Id = 4, Nome = "Administrador", Saldo = 0, UserName="admin", Password="admin123", Role="admin"  });

            return listaDomain;

        }

        public IEnumerable<ClienteDomain> ListarPublico()
        {
            var clientes = Listar().ToList().Where(c => c.Role == "cliente").ToList();

            foreach(var c in clientes)
            {
                c.Saldo = 0;
                c.Password = string.Empty;
                c.Token = string.Empty;
            }

            return clientes;
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

 

        public ClienteDomain Login(string UserName, string Password)
        {
            return Listar().Where(c => c.UserName == UserName && c.Password == Password).FirstOrDefault();
        }

  
    }
}
