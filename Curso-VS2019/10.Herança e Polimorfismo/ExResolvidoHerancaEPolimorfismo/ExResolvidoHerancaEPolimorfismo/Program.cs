using System;
using System.Globalization;
using System.Collections.Generic;
using ExResolvidoHerancaEPolimorfismo.Entities;

namespace ExResolvidoHerancaEPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listOfEmployees = new List<Employee>();
            
            Console.Write("Enter the number of employees: ");
            var numberOfEmployees = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numberOfEmployees; i++)
            {
                Console.WriteLine($"\nEmployee #{i} data:");
                Console.Write("Outsourcerd (Y/N)? ");
                var OutsourcedOrNot = char.Parse(Console.ReadLine().ToUpper());

                Console.Write("Name: ");
                var name = Console.ReadLine();
                
                Console.Write("Hours: ");
                var hours = int.Parse(Console.ReadLine());

                Console.Write("Varlue per hour: ");
                var valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (OutsourcedOrNot == 'Y')
                {
                    Console.Write("Additional charge: ");
                    var additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listOfEmployees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                    listOfEmployees.Add(new Employee(name, hours, valuePerHour));
            }

            Console.WriteLine("\nPayments".ToUpper());
            foreach(Employee emp in listOfEmployees)
            {
                Console.WriteLine($"{emp.Name} - R${emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
