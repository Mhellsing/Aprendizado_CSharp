using System;
using System.Globalization;

namespace ExFixação___01
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("RETÂNGULOS");
            Console.Write("\nLargura: ");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Altura: ");
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"\nArea do retângulo: {ret.Area().ToString("F2", CultureInfo.InvariantCulture)}cm2");
            Console.WriteLine($"Perímetro do retângulo: {ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}cm");
            Console.WriteLine($"Diagonal do retângulo: {ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}cm");

        }
    }
}
