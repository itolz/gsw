using System;
using System.Collections.Generic;
using System.Text;
using gswSoftware.Domain.Interfaces;
using gswSoftware.Domain.Models;

namespace gswSoftware.Domain.Service
{

    public class DispensarNotasDomain : IDispensarNotasDomain
    {
        public DispensarNotasDomain()
        {

        }

        public List<CedulaDomain> Execute(int valorSolicitado)
        {
            var cedulaCem = new CedulaDispensadoraDomain(100);
            var cedulaCinquenta = new CedulaDispensadoraDomain(50);
            var cedulaVinte = new CedulaDispensadoraDomain(20);
            var cedulaDez = new CedulaDispensadoraDomain(10);

            var cedulas = new List<CedulaDomain>();

            cedulaCem.SetNext(cedulaCinquenta);
            cedulaCinquenta.SetNext(cedulaVinte);
            cedulaVinte.SetNext(cedulaDez);
            cedulaCem.SelecionarNotas(valorSolicitado, cedulas);

            return cedulas;
        }
    }
}
