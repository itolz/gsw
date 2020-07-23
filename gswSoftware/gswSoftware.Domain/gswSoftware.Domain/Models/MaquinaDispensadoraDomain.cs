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

        public abstract void SelecionarNotas(int valorSolicitado, List<NotaDomain> listaCedulas);
  

        public void SetNext(MaquinaDispensadoraDomain next) {
            Next = next; 
        }

        public List<NotaDomain> DispensarNotas(List<NotaDomain> lista)
        {
            return lista;
        }

    }

}
