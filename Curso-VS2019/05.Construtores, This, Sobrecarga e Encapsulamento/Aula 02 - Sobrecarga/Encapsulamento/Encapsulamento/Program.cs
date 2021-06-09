using System;
using System.Globalization;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto("tv", 250.00, 10);
            p1.SetNome("TV 4K");
            
            //Console.WriteLine(p1.nome); Apresenta erro, pois, o atributo definido como privado não pode ser acessado por outras Classes;
            Console.WriteLine(p1.GetNome()); //Obtendo o nome do produto;
            Console.WriteLine(p1.GetPreco());
        }
    }
}