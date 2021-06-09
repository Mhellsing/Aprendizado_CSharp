using System;
using System.Globalization;
using System.Collections.Generic;
using ExFixacaoListas.Classes;

namespace ExFixacaoListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> listaDeFuncionarios = new List<Funcionario>();

            Console.WriteLine("Alteração Salarial\n");
            Console.Write("Informe a quantidade de funcionários para aumento de salário: ");
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var funcionario = new Funcionario();
                funcionario.RecebeDadosDeFuncionario();
                listaDeFuncionarios.Add(funcionario);
            }

            Console.Write("\nInforme o Id do funcionário que receberá o aumento: ");
            var conferirIdParaAumentoDeSalario = int.Parse(Console.ReadLine());

            //tive de olhar este trecho na solução.
            var recebeFuncionario = listaDeFuncionarios.Find(x => x.Id == conferirIdParaAumentoDeSalario);

            if (recebeFuncionario != null)
            {
                Console.Write($"Porcentagem de aumento salarial: ");
                var percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                recebeFuncionario.AumentaSalario(percent);
            }
            else
                Console.WriteLine("Funcionário inexistente.");

            Console.WriteLine("\nDados atualizados de cada funcionário");
            foreach (Funcionario objetos in listaDeFuncionarios)
            {
                Console.WriteLine(objetos);
            }
        }
    }
}
