using gswSoftware.Domain.Models;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace gswSoftware.Domain
{
    public abstract class MaquinaDispensadoraDomain
    {
        protected  MaquinaDispensadoraDomain Next;

        public int DenominacaoNota { get; }

        public abstract void SelecionarNotas(int valorSolicitado, List<CedulaDomain> listaCedulas);
  

        public void SetNext(MaquinaDispensadoraDomain next) {
            Next = next; 
        }

        public List<CedulaDomain> DispensarNotas(List<CedulaDomain> lista)
        {
            return lista;
        }

    }

}
