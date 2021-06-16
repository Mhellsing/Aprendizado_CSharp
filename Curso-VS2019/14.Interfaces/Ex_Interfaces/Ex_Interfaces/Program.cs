using System;
using System.Globalization;
using Ex_Interfaces.Entities;
using Ex_Interfaces.Services;

namespace Ex_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CONTRATOS!");
            Console.Write("Número do contrato: ");
            var numeroDoContrato = int.Parse(Console.ReadLine());

            Console.Write("Data de assinatura do contrato (dd/MM/yyyy): ");
            DateTime dataDoContrato = DateTime.Parse(Console.ReadLine());

            Console.Write("Valor Total do Contrato: R$");
            var valorTotalDoContrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Informe o número de parcelas do contrato: ");
            var numeroDeParcelas = int.Parse(Console.ReadLine());

            Contrato novoContrato = new Contrato(numeroDoContrato, dataDoContrato, valorTotalDoContrato);
            PagamentoPayPal pagamentoPayPal = new PagamentoPayPal();

            var listaDeParcelas = pagamentoPayPal.CalcularValorDasParcelas(valorTotalDoContrato, dataDoContrato, numeroDeParcelas);

            listaDeParcelas.ForEach(parcela =>
            {
                //Console.WriteLine($"{parcela.DataDeVenciMentoDaParcela} - {parcela.ValorDaParcela}");
                Console.WriteLine(parcela.ToString());
            });


        }
    }
}
