using System;
using System.Globalization;

namespace Exercício_03___Métodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            
            Console.WriteLine("Informe os dados do produto: ");
            
            Console.Write("Nome do produto: ");
            p1.Nome = Console.ReadLine();

            Console.Write("Preço do produto: R$");
            p1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade em estoque: ");
            p1.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nDados do produto: \n{p1}");

            Console.Write("\nDigite a quantidade de produto a ser adicionada ao estoque: ");
            int qtde = int.Parse(Console.ReadLine());
            p1.AdicionarProdutos(qtde);

            Console.WriteLine($"\nDados atualizados: \n{p1}");

            Console.Write("\nDigite a quantidade de produto a ser removida do estoque: ");
            qtde = int.Parse(Console.ReadLine());
            p1.RemoverProdutos(qtde);

            Console.WriteLine($"\nDados atualizados: \n{p1}");

        }
    }
}
