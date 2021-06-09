using System;
using System.Globalization;

namespace ExFixação_Vetores{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de produtos: ");
            var n = int.Parse(Console.ReadLine());

            Produtos[] vetorDeProdutos = new Produtos[n];

            for (int i = 0; i < vetorDeProdutos.Length; i++)//.length sempre pegará o tamanho total do vetor de produtos.
            {
                Console.Write($"\n{i+1}º Produto: ");
                var name = Console.ReadLine();

                Console.Write("Preço: R$");
                var price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vetorDeProdutos[i] = new Produtos (name, price);
            }

            double soma = 0;
            for (int i = 0; i < vetorDeProdutos.Length; i++)
            {
                soma += vetorDeProdutos[i].Price;
            }

            double media = soma / vetorDeProdutos.Length;
            Console.WriteLine($"\nMédia de preços: R${media.ToString("F2", CultureInfo.InvariantCulture)}");}
    }
}
