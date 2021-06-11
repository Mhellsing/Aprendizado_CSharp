using System;
using System.Globalization;

namespace ExFixação___02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            double aumento;

            Console.WriteLine("=== FOLHA DE PAGAMENTO ===");
            Console.Write("\nNome: ");
            f1.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: R$");
            f1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Impostos: R$");
            f1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nDADOS DE PAGAMENTO DO FUNCIONÁRIO");
            Console.WriteLine($"{f1}");

            Console.Write("\n% de Aumento para funcionários: ");
            aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f1.AumentarSalario(aumento);

            Console.WriteLine($"\nDADOS ATUALIZADOS");
            Console.WriteLine($"{f1}");
        }
    }
}
