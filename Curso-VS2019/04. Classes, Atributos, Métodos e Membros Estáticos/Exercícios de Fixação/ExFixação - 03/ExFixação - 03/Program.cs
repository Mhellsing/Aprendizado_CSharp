using System;
using System.Globalization;

namespace ExFixação___03
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.Write("Nota 1º Trimestre: ");
            aluno.Nota01 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
            Console.Write("Nota 2º Trimestre: ");
            aluno.Nota02 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Nota 3º Trimestre: ");
            aluno.Nota03 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write($"Nota final: {aluno.SomatorioDeNotas()}");

            aluno.AprovaReprova();

        }
    }
}
