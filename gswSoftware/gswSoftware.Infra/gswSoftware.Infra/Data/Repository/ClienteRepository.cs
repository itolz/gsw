﻿using Dapper;
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
    public class ClienteRepository : IClienteRepository
    {
        public ClienteRepository()
        {
         
        }

        public IEnumerable<ClienteDomain> ListarPublico()
        {

            using (SqlConnection conexao = new SqlConnection(""))
            {
                return conexao.Query<ClienteDomain>("select Id, Nome, role from [dbo].[Clientes] where role='cliente'");
            }
        }

        public IEnumerable<ClienteDomain> Listar()
        {

            using (SqlConnection conexao = new SqlConnection(""))
            {
                return conexao.Query<ClienteDomain>("select Id, Nome, Saldo, UserName, Password, Role from [dbo].[Clientes]");
            }
        }
      

        public int AtualizarSaldo(int Id, int saldo)
        {
            using (SqlConnection conexao = new SqlConnection(""))
            {
                return conexao.Execute("update dbo.Clientes set Saldo = @saldo Where Id = @id", new { saldo, id = Id });
            }
        }

        public int Editar(int Id, string nome, int saldo)
        {
            using (SqlConnection conexao = new SqlConnection(""))
            {
                return conexao.Execute("update dbo.Clientes set Nome = @nome,  Saldo = @saldo Where Id = @id", new { nome, saldo, id = Id });
            }
        }

        public int Deletar(int Id)
        {
            using (SqlConnection conexao = new SqlConnection(""))
            {
                return conexao.Execute("delete from   dbo.Clientes where Id = @id", new { id = Id });
            }
        }

        public int Insert(string nome, int saldo, string role, string userName, string password)
        {
            using (SqlConnection conexao = new SqlConnection(""))
            {
                return conexao.Execute("insert into  dbo.Clientes(Nome, Saldo, role, userName, password) values (@Nome, @Saldo, @role, @userName, @password)", new { nome, saldo, role, userName, password });
            }
        }

        public ClienteDomain Selecionar(int Id)
        {
            using (SqlConnection conexao = new SqlConnection(""))
            {
                return conexao.QueryFirstOrDefault<ClienteDomain>("select Id, Nome, Saldo from [dbo].[Clientes]  where Id = @id", new { id = Id });
            }
        }

        public ClienteDomain Login(string UserName, string Password)
        {
            using (SqlConnection conexao = new SqlConnection(""))
            {
                return conexao.QueryFirstOrDefault<ClienteDomain>("select Id, Nome, Role from [dbo].[Clientes]  where UserName = @UserName and Password = @Password", new { UserName, Password });
            }
        }

        
    }
}
