using System;
using System.Globalization;

namespace Entrada_de_dados_parte_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);*/

            string[] vetor = Console.ReadLine().Split(' ');
            string nome = vetor[0];
            char sexo = char.Parse(vetor[1]);
            int idade = int.Parse(vetor[2]);
            double altura = double.Parse(vetor[3], CultureInfo.InvariantCulture);

            /*Console.WriteLine($"Você digitou: {n1}");
            Console.WriteLine($"Você digitou: {ch}");
            Console.WriteLine("Você digitou: " + n2.ToString("F2", CultureInfo.InvariantCulture));*/
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
