using System;
using AulaHeranca.Entities;
namespace AulaHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //BusinessAccount account = new BusinessAccount(8010, "Billy Butcher", 100.0, 500.0);
            //Console.WriteLine(account.Balance);
            //account.Balance = 200.0; atributo protegido impossibilita a sua alteração no main.
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //UPCASTING
            Account acc1 = bacc;//Uma variável do tipo X recebe naturalmente um objeto do mesmo tipo de subclasse proveniente de X;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            //DOWNCASTING
            BusinessAccount acc4 = (BusinessAccount)acc2;//O compilador não consegue converter implicitamente o objeto account para businessaccount;
            acc4.Loan(100.0);
            //BusinessAccount acc5 = (BusinessAccount)acc3;

        }
    }
}
