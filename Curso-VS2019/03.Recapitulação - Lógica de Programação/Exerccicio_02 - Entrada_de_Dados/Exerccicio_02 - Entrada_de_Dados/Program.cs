using System;
using System.Globalization;

namespace Exercicio_02_Entrada_de_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("\nQuantos quartos tem na sua casa? ");
            int n_Quarto = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEntre com o preço de um produto: ");
            float preco = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nEntre com seu último nome, idade e altura.");
            string[] vetor = Console.ReadLine().Split(' ');
            string ultimo_nome = vetor[0];
            int idade = int.Parse(vetor[1]);
            float altura = float.Parse(vetor[2], CultureInfo.InvariantCulture);

            Console.WriteLine("\n=============================================================\n");

            Console.WriteLine($"\nSeu nome é: {nome}");
            Console.WriteLine($"\nSua casa tem {n_Quarto} quartos.");
            Console.WriteLine($"\nO preço do produto é de R${preco.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"\nSeu último nome é: {ultimo_nome}");
            Console.WriteLine($"\nSua idade é: {idade} anos.");
            Console.WriteLine($"\nSua altura é de {altura.ToString("F2", CultureInfo.InvariantCulture)}m");
        }
    }
}
