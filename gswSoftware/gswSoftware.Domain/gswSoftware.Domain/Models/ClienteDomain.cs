﻿using System;
using System.Collections.Generic;
using System.Text;

namespace gswSoftware.Domain.Models
{
    public class ClienteDomain
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Saldo { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }

        public string Token { get; set; }

    }
}
