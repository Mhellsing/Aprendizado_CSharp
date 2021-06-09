using System;
using System.Globalization;

namespace Saida_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Marcia";

            Console.WriteLine("{0} tem {1} e tem {2:f2} reais.", nome, idade, saldo);//placeholders
            Console.WriteLine($"{nome} tem {idade} e tem {saldo:f2} reais.");//Interpolação
            Console.WriteLine(nome + " tem " + idade + " e tem " + saldo.ToString("f2", CultureInfo.InvariantCulture) + " reais." );//concatenação

           /*Console.Write("Bom dia!");
            Console.WriteLine("Boa Tarde!");
            Console.WriteLine("Boa Noite!");
            Console.WriteLine("---------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("f2"));//Regra de arredondamento para definir a última casa decimal apresentada.
            Console.WriteLine(saldo.ToString("f4"));
            Console.WriteLine(saldo.ToString("f4", CultureInfo.InvariantCulture));//Função para troca da vírgula pelo ponto para separação de valores de acordo com o país.*/
        }
    }
}
