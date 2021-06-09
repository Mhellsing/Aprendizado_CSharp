using System;
using System.Globalization;

namespace ExFixacaoListas.Classes
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario()
        {
            //Id = id;
            //Nome = nome;
            //Salario = salario;
        }

        public void RecebeDadosDeFuncionario()
        {
            Console.Write("\nId: ");
            var id = int.Parse(Console.ReadLine());
            Id = id;

            Console.Write("Nome: ");
            var nome = Console.ReadLine();
            Nome = nome;

            Console.Write("Salario: R$");
            var salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Salario = salario;
        }

        public double AumentaSalario(double percent)
        {
            return Salario += Salario * percent / 100;
        }

        public override string ToString()
        {
            return $"\nId: {Id}\nNome: {Nome}\nSalário: {Salario}.";
        }
    }
}
