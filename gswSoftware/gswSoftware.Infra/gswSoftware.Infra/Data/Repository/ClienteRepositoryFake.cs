using gswSoftware.Domain.Interfaces;
using gswSoftware.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gswSoftware.Infra.Data.Repository
{
    public class ClienteRepositoryFake : IClienteRepository
    {
        private List<ClienteDomain> listaDomain;

        public ClienteRepositoryFake()
        {
            listaDomain = new List<ClienteDomain>();

            listaDomain.Add(new ClienteDomain { Id = 1, Nome = "Aline Bretas", Saldo = 800, UserName = "aline", Password = "cliente123", Role = "cliente" });
            listaDomain.Add(new ClienteDomain { Id = 2, Nome = "Laura Bretas", Saldo = 30, UserName = "laura", Password = "cliente123", Role = "cliente" });
            listaDomain.Add(new ClienteDomain { Id = 3, Nome = "Sofia Bretas", Saldo = 130, UserName = "sofia", Password = "cliente123", Role = "cliente" });
            listaDomain.Add(new ClienteDomain { Id = 4, Nome = "Administrador", Saldo = 0, UserName = "admin", Password = "admin123", Role = "admin" });
        }
        public int Deletar(int Id)
        {
            listaDomain.RemoveAll(c => c.Id == Id);
            return 0;
        }

        public int Insert(string nome, int saldo, string role, string userName, string password)
        {
            var id = listaDomain.Max(x => x.Id) + 1;

            listaDomain.Add(new ClienteDomain { Id = id, Nome = nome, Saldo = saldo, UserName = userName, Password = password, Role = role });

            return 0;
        }

        public IEnumerable<ClienteDomain> Listar()
        {
          
           

            return listaDomain;

        }

        public IEnumerable<ClienteDomain> ListarPublico()
        {
            List<ClienteDomain> listaPublica = new List<ClienteDomain>();

            var clientes = Listar().ToList().Where(c => c.Role == "cliente").ToList();

            foreach (var c in clientes)
            {
                listaPublica.Add(new ClienteDomain {Id= c.Id, Nome  = c.Nome, Saldo = c.Saldo, UserName = c.UserName});
            }

            return listaPublica;
        }

        public ClienteDomain Selecionar(int Id)
        {
            return Listar().Where(c => c.Id == Id).FirstOrDefault();
        }

        public int AtualizarSaldo(int Id, int saldo)
        {
            listaDomain.Where(c => c.Id == Id).FirstOrDefault().Saldo = saldo;
            return 0;
        }

        public int Editar(int Id, string nome, int saldo)
        {
            listaDomain.Where(c => c.Id == Id).FirstOrDefault().Saldo = saldo;

            return 0; 
        } 



        public ClienteDomain Login(string UserName, string Password)
        {
            return Listar().Where(c => c.UserName == UserName && c.Password == Password).FirstOrDefault();
        }


    }
}
