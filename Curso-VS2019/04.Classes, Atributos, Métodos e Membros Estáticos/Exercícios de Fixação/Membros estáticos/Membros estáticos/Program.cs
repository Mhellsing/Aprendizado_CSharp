using System;
using System.Globalization;

namespace Membros_estáticos
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double circ = Calculculadora.Circunferencia(raio);
            double vol = Calculculadora.Volume(raio);
            
            Console.WriteLine($"\nCircunferência: {circ.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {vol.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de Pi: {Calculculadora.v.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}