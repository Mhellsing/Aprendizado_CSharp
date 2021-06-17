using System;
using System.Globalization;
using ExFixacao_Exceccoes.Entities.DomainExceptions;
namespace ExFixacao_Exceccoes.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amountOfWithdraw)
        {
            if(Balance == 0 || amountOfWithdraw > Balance)
            {
                throw new DomainException("Insufficient funds.");
            }
            if(amountOfWithdraw > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit.");
            }            
            Balance -= amountOfWithdraw;
        }

        public override string ToString()
        {
            return $"\nAC: {Number}\n" +
                   $"Holder name: {Holder}\n" +
                   $"Initial balance: ${Balance.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                   $"Withdraw limit: ${WithdrawLimit.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
