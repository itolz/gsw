﻿using gswSoftware.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using gswSoftware.Domain.Models;

namespace gswSoftware.Domain.Service
{
    public class OperarSaqueDomain : DomainBase, IOperarSaqueDomain
    {

        public RetornoOperacaoDomain Execute(int IdCliente, int valorSolicitado)
        {
            var retornoOperacao = new RetornoOperacaoDomain();

            var serviceValidarSaldo = provider.GetService<IValidarSaldoDomain>();
            var serviceAtualizarSaldo = provider.GetService<IAtualizarSaldoDomain>();
            var serviceDispensarNotasDomain = provider.GetService<IDispensarNotasDomain>();
            var serviceSelecionarCliente = provider.GetService<ISelecionarCliente>();

            try
            {
                if (serviceValidarSaldo.Execute(IdCliente, valorSolicitado))
                {
                    var cedulasDispensadas = serviceDispensarNotasDomain.Execute(valorSolicitado);

                    var cliente = serviceSelecionarCliente.Execute(IdCliente);

                    serviceAtualizarSaldo.Execute(IdCliente, cliente.Saldo - valorSolicitado);

                    retornoOperacao.MensagemRetornoAmigavel = "Saque efetuado com sucesso!";
                    retornoOperacao.CedulasDispensadas = cedulasDispensadas;
                    retornoOperacao.TipoRetorno = 0;
                    retornoOperacao.ValorSaque = valorSolicitado;
                }
                else
                {
                    retornoOperacao.MensagemRetornoAmigavel = "Saldo Insuficiente";
                    retornoOperacao.TipoRetorno = 1;
                    retornoOperacao.ValorSaque = 0;

                }
            }
            catch (Exception)
            {
                retornoOperacao.MensagemRetornoAmigavel = "Houve erro na operação";
                retornoOperacao.TipoRetorno = 2;
            }

            return retornoOperacao;
        }
    }
}