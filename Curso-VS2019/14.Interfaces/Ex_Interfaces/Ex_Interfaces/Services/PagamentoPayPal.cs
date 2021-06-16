using System;
using System.Collections.Generic;
using Ex_Interfaces.Entities;

namespace Ex_Interfaces.Services
{
    class PagamentoPayPal : IServicoDePagamentoOnline
    {
        const double juros = 0.01;
        const double taxaDePagamento = 0.02;

        private double JurosSimples(double valorDaParcela, int mes)
        {
            return valorDaParcela + (valorDaParcela * juros * mes);
        }

        private double TaxaDePagamento(double valorDaParcela)
        {
            return valorDaParcela + (valorDaParcela * taxaDePagamento);
        }

        public List<Parcelas> CalcularValorDasParcelas(double valorTotalDoContrato, DateTime dataInicialDoContrato, int numeroDeParcelas)
        {
            var valorDaParcela = valorTotalDoContrato / numeroDeParcelas;
            List<Parcelas> listaDeParcelas = new List<Parcelas>();

            for (int i = 1; i <= numeroDeParcelas; i++)
            {
                var valorFinalDaParcela = JurosSimples(valorDaParcela, i);
                valorFinalDaParcela = TaxaDePagamento(valorFinalDaParcela);
                var parcela = new Parcelas(dataInicialDoContrato.AddMonths(i), valorFinalDaParcela);
                listaDeParcelas.Add(parcela);
            }
            return listaDeParcelas;
        }
    }
}
