using System;
using System.Globalization;

namespace ExFixação01//(Construtores, sobrecarga, encapsulamento);
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria;

            Console.WriteLine("=== ABERTURA DE CONTA BANCÁRIA ===");

            Console.Write("\nInforme o número da conta bancária: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Informe o nome do titular da conta bancária: ");
            string nomeTitular = Console.ReadLine();

            Console.Write("Haverá Saldo inicial (S/N)? ");
            var decisao_01 = char.Parse(Console.ReadLine());
            if (decisao_01 == 's' || decisao_01 == 'S')
            {
                Console.Write("Informe o valor inicial a ser depositado: R$");
                var valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaBancaria = new ContaBancaria(numeroConta, nomeTitular, valorInicial);
            }
            else
            {
                contaBancaria = new ContaBancaria(numeroConta, nomeTitular);
            }

            Console.WriteLine(contaBancaria);

            int decisao_02 = 0;
            while (decisao_02 != 3)
            {
                Console.WriteLine("\nDeseja realizar mais alguma ação? \n1-Depósito \n2-Saque \n3-Sair do Programa");
                decisao_02 = int.Parse(Console.ReadLine());
                if (decisao_02 == 1)
                {
                    Console.Write("\nDeposito");
                    Console.Write("\nInforme o valor a ser depositado: R$ ");
                    var valorDeposito = double.Parse(Console.ReadLine());

                    contaBancaria.Deposito(valorDeposito);

                    Console.WriteLine("\nDados Atualizados");
                    Console.WriteLine(contaBancaria);
                }
                else if (decisao_02 == 2)
                {
                    Console.Write("\nSaque");
                    Console.Write("\nInforme o valor a ser sacado: R$ ");
                    var valorSaque = double.Parse(Console.ReadLine());

                    contaBancaria.Saque(valorSaque);

                    Console.WriteLine("\nDados Atualizados");
                    Console.WriteLine(contaBancaria);
                }
            }
            Console.WriteLine("=== Programa Encerrado ===");
        }
    }
}