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
        public override void SelecionarNotas(int valorSolicitado, List<NotaDomain> listaCedulas)
        {
            if (listaCedulas == null) new List<NotaDomain>();

            while (valorSolicitado >= ValorCedula)
            {
                listaCedulas.Add(new NotaDomain { Valor = ValorCedula });
                valorSolicitado -= ValorCedula;
            }

            if (Next != null)
                Next.SelecionarNotas(valorSolicitado, listaCedulas);
        }
    }
}
