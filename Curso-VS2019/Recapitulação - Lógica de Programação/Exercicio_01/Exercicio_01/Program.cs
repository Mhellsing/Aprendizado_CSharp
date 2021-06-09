﻿using System;
using System.Globalization;
namespace Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;
            
            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo o preço é R${preco1}");
            Console.WriteLine($"{produto2}, cujo o preço é R$ {preco2}");
            Console.WriteLine("\n");
            Console.WriteLine($"Registro:{idade} de idade, código: {codigo} e gênero:{genero}");
            Console.WriteLine("\n");
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arrendondado (três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
