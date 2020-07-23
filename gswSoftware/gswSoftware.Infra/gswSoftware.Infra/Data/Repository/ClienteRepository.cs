using Dapper;
using gswSoftware.Domain.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace gswSoftware.Infra.Data.Repository
{
    internal class ClienteRepository
    {
        private IConfiguration _config;

        public ClienteRepository(IConfiguration config)
        {
            _config = config;
        }

        public IEnumerable<ClienteDomain> Listar()
        {
            using (SqlConnection conexao = new SqlConnection(_config.GetConnectionString("cs")))
            {
                return conexao.Query<ClienteDomain>("select Id, Nome, Saldo from [dbo].[Clientes]");
            }
        }

        public int Update(int Id, int saldo)
        {
            using (SqlConnection conexao = new SqlConnection(_config.GetConnectionString("cs")))
            {


                return conexao.Execute("update dbo.Clientes set Saldo = @saldo Where Id = @id", new { saldo, id = Id });
            }
        }

        public int Insert(ClienteDomain cliente)
        {
            using (SqlConnection conexao = new SqlConnection(_config.GetConnectionString("cs")))
            {
                return conexao.Execute("insert into  dbo.Clientes(Nome, Saldo) values (@Nome, @Saldo)", new { cliente.Nome, cliente.Saldo });
            }
        }

        public int Deletar(int Id)
        {
            using (SqlConnection conexao = new SqlConnection(_config.GetConnectionString("cs")))
            {
                return conexao.Execute("delete from   dbo.Clientes where Id = @id", new { id = Id });
            }
        }
    }
}
