using System;
using System.Globalization;
using AulaComposicao.Entities;
using AulaComposicao.Entities.Enums;
namespace AulaComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department name: ");
            string departName = Console.ReadLine();
            
            Console.WriteLine("\nEnter worker data");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            
            Console.Write("Level (1-Junior/ 2-Midlevel/ 3-Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base Salary - R$");
            var baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department department = new Department(departName);
            Worker worker = new Worker (name, level, baseSalary, department);

            Console.Write("\nHow many contract to this worker? ");
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine($"\nEnter #{i} contract data");
                Console.Write("Date(dd/mm/yyyy): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                
                Console.Write("Value per hour - R$");
                var valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration: ");
                var hour = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hour);
                worker.AddContract(contract);
            }

            Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
            var monthAndYear = Console.ReadLine();
            var month = int.Parse(monthAndYear.Substring(0, 2));
            var year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine($"\nName: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {monthAndYear}: R${worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
