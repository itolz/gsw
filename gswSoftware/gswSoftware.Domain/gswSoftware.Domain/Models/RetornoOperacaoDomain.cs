using System;
using System.Collections.Generic;
using System.Text;

namespace gswSoftware.Domain.Models
{
    public class RetornoOperacaoDomain
    {
        public string MensagemRetornoAmigavel { get; set; }

        public List<CedulaDomain> CedulasDispensadas { get; set; }

        public int TipoRetorno { get; set; }

        public int ValorSaque { get; set; }
    }
}
