using Dapper;
using gswSoftware.Domain.Interfaces;
using gswSoftware.Domain.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace gswSoftware.Infra.Data.Repository
{
    internal class ClienteRepository : IClienteRepository
    {
       

        public ClienteRepository()
        {
         
        }

        public IEnumerable<ClienteDomain> Listar()
        {
            using (SqlConnection conexao = new SqlConnection(""))
            {
                return conexao.Query<ClienteDomain>("select Id, Nome, Saldo from [dbo].[Clientes]");
            }
        }

        public int Update(int Id, int saldo)
        {
            using (SqlConnection conexao = new SqlConnection(""))
            {


                return conexao.Execute("update dbo.Clientes set Saldo = @saldo Where Id = @id", new { saldo, id = Id });
            }
        }

        public int Deletar(int Id)
        {
            using (SqlConnection conexao = new SqlConnection(""))
            {
                return conexao.Execute("delete from   dbo.Clientes where Id = @id", new { id = Id });
            }
        }

        public int Insert(string nome, int saldo)
        {
            using (SqlConnection conexao = new SqlConnection(""))
            {
                return conexao.Execute("insert into  dbo.Clientes(Nome, Saldo) values (@Nome, @Saldo)", new { nome, saldo });
            }
        }

        public ClienteDomain Selecionar(int Id)
        {
            using (SqlConnection conexao = new SqlConnection(""))
            {
                return conexao.QueryFirstOrDefault<ClienteDomain>("select Id, Nome, Saldo from [dbo].[Clientes]  where Id = @id", new { id = Id });
            }
        }
    }
}
