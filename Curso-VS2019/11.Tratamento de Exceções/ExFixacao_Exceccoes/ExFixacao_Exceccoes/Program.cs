using System;
using System.Globalization;
using ExFixacao_Exceccoes.Entities;
using ExFixacao_Exceccoes.Entities.DomainExceptions;

namespace ExFixacao_Exceccoes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter account data\n");
            Console.Write("Number: ");
            var accountNumber = int.Parse(Console.ReadLine());

            Console.Write("Holder name: ");
            var holderName = Console.ReadLine();

            Console.Write("Initial Balance: $");
            var initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Withdraw Limit: $");
            var withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(accountNumber, holderName, initialBalance, withdrawLimit);

            Console.Write("\nEnter amount of withdraw: $");
            var amountOfWithdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                account.Withdraw(amountOfWithdraw);
                Console.WriteLine("\nNew Balance");
                Console.WriteLine(account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainException errorMessage)
            {
                Console.WriteLine($"Withdraw error: {errorMessage.Message}");
            }
        }
    }
}
