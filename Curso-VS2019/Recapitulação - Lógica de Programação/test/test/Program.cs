using System;
using System.Globalization;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            x.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nEntre com as medidas do triangulo Y: ");
            y.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.a + x.b + x.c) / 2.0;
            double area_x = Math.Sqrt(p * (p - x.a) * (p - x.b) * (p - x.c));

            p = (y.a + y.b + y.c) / 2.0;
            double area_y = Math.Sqrt(p * (p - y.a) * (p - y.b) * (p - y.c));

            Console.WriteLine($"\nÁrea de X = {area_x.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"\nÁrea de Y = {area_y.ToString("F4", CultureInfo.InvariantCulture)}");

            if (area_x > area_y)
            {
                Console.WriteLine("\nMaior área = X");
            }
            else
            {
                Console.WriteLine("\nMaior área = y");
            }
        }
    }
}
