using Solucao_Com_Interface1.Entities;
using Solucao_Com_Interface1.Services;
using System;
using System.Globalization;

namespace Solucao_Com_Interface1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Rental Date");

            Console.Write("Car Model: ");
            var model = Console.ReadLine();

            Console.Write("Pickup (dd/MM/yyyy HH:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Return (dd/MM/yyyy HH:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: $");
            var hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter price per day: $");
            var day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day, new BrazilTaxServices());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("Invoice");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
