using System;
using System.Globalization;
using System.Collections.Generic;
using Ex_Resolvido_Metodos_Abstratos.Entities;
using Ex_Resolvido_Metodos_Abstratos.Entities.Enums;

namespace Ex_Resolvido_Metodos_Abstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> listOfShapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            var numberOfShapes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfShapes; i++)
            {
                Console.WriteLine($"\nShape #{i} Data");
                Console.Write("Rectangle or Circle (R/C): ");
                var rectangleOrCircle = char.Parse(Console.ReadLine().ToUpper());

                Console.Write("Color (Black/Blue/Red)? ");
                var color = Enum.Parse<Color>(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine()));
                //var color = Enum.Parse<Color>(Console.ReadLine());

                if (rectangleOrCircle == 'R')
                {
                    Console.Write("Width: ");
                    var width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Height: ");
                    var height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listOfShapes.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    var radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listOfShapes.Add(new Circle(radius, color));
                }                   

            }
            Console.WriteLine("\nShape Areas");

            foreach (Shape shape in listOfShapes)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
