using System;

namespace ExVetores.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vetor = new Estudante[10];

            Console.Write("Quantos quartos serão alugados: ");
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n{i + 1}º Aluguel");

                Console.Write("Nome: ");
                var nome = Console.ReadLine();

                Console.Write("Email: ");
                var email = Console.ReadLine();

                Console.Write("Nº do Quarto: ");
                var numero = int.Parse(Console.ReadLine());
                vetor[numero] = new Estudante(nome, email);
            }

            Console.WriteLine("\nQuartos Ocupados\n");
            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] != null)
                {
                    Console.WriteLine($"{i}: {vetor[i]}");
                }
            }
        }
    }
}
