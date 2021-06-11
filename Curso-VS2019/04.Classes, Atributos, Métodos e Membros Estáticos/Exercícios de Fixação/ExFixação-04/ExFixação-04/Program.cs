using System;
using System.Globalization;

namespace ExFixação_04
{
    class Program
    {
        static void Main(string[] args)
        {
            double cotacaodolar;
            double quantia;
            
            Console.Write("Qual é a cotação do dólar? $");
            cotacaodolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? $");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Valor a ser pago em reais = R$");
            double total = ConversorDeMoeda.Conversao(cotacaodolar, quantia);
            Console.Write(total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
