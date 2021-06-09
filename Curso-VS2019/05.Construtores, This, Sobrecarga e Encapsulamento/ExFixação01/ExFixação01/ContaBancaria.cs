using System;
using System.Globalization;

namespace ExFixação01
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroConta, string nomeTitular)
        {
            Numero = numeroConta;
            NomeTitular = nomeTitular;
        }

        public ContaBancaria(int numeroConta, string nomeTitular, double saldo) : this(numeroConta, nomeTitular)
        {
            Saldo = saldo;
        }

        public double Deposito(double valorDeposito)
        {
            return Saldo += valorDeposito;
        }

        public double Saque(double valorSaque)
        {
            return Saldo -= valorSaque + 5;
        }

        public override string ToString()
        {
            return $"Conta: {Numero} | Titular: {NomeTitular} | Saldo: R${Saldo.ToString("F2", CultureInfo.InvariantCulture)} ";
        }

    }


}