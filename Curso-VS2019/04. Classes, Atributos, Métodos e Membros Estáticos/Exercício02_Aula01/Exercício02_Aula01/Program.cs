using System;
using System.Globalization;
namespace Exercício02_Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Informe os dados do primeiro funcionário:");
            string func01_nome = Recebe_nome(f1.nome);
            double func01_salario = Recebe_salario(f1.salario);

            Console.WriteLine("\n=========================================");
            Console.WriteLine("\nInforme os dados do segundo funcionário:");
            string func02_nome = Recebe_nome(f2.nome);
            double func02_salario = Recebe_salario(f2.salario);

            Console.WriteLine("\n=========================================");
            Console.WriteLine("Funcionário 01:");
            Printar(func01_nome);
            Printar(func01_salario);

            Console.WriteLine("\n=========================================");
            Console.WriteLine("Funcionário 02:");
            Printar(func02_nome);
            Printar(func02_salario);

            Console.WriteLine("\n=========================================");
            Console.Write("Média entre os salários: ");
            Printar(Media(func01_salario, func02_salario));
        }
        static string Recebe_nome(string a)
        {
            Console.Write("Nome: ");
            a = Console.ReadLine();
            return a;
        }
        static double Recebe_salario(double b)
        {
            Console.Write("Salário: R$ ");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return b;
        }
        static string Printar(string a)
        {
            Console.WriteLine($"\nNome: {a}");
            return a;
        }
        static double Printar(double b)
        {
            Console.WriteLine($"Salário: {b}");
            return b;
        }
        static double Media(double a, double b)
        {
            double c = (a + b) / 2;
            return c;
        }
    }
}
