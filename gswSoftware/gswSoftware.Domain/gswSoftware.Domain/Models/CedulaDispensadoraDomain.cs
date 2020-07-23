using System;
using System.Collections.Generic;
using System.Text;

namespace gswSoftware.Domain.Models
{
    public class CedulaDispensadoraDomain : MaquinaDispensadoraDomain
    {

        private int ValorCedula;

        public CedulaDispensadoraDomain(int valorCedula)
        {
            ValorCedula = valorCedula;
        }
        public override void SelecionarNotas(int valorSolicitado, List<CedulaDomain> listaCedulas)
        {
            if (listaCedulas == null) new List<CedulaDomain>();

            while (valorSolicitado >= ValorCedula)
            {
                listaCedulas.Add(new CedulaDomain { Cedula = ValorCedula });
                valorSolicitado -= ValorCedula;
            }

            if (Next != null)
                Next.SelecionarNotas(valorSolicitado, listaCedulas);
        }
    }
}
