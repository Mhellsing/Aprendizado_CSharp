using System;

namespace Exercicio_aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;

            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Informe os dados da primeira pessoa:");
            Console.Write("Nome: ");
            p1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme os dados da segunda pessoa:");
            Console.Write("Nome: ");
            p2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("\n================================================");
            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write($"Nome: {p1.nome}");
            Console.Write($"\nIdade: {p1.idade}\n");

            Console.WriteLine("\n================================================");
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write($"Nome: {p2.nome}");
            Console.Write($"\nIdade: {p2.idade}\n");

            Console.WriteLine("\n================================================");

            if(p1.idade > p2.idade)
            {
                Console.WriteLine($"{p1.nome} é a pessoa mais velha..");
            }
            else
            {
                Console.WriteLine($"{p2.nome} é a pessoa mais velha.");
            }
        }
    }
}
