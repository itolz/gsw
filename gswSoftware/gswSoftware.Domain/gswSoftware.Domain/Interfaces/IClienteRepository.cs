﻿using gswSoftware.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace gswSoftware.Domain.Interfaces
{
    public interface IClienteRepository
    {
        public IEnumerable<ClienteDomain> Listar();

        public int Update(int Id, int saldo);

        public int Insert(string nome, int saldo);

        public int Deletar(int Id);

    }
}
