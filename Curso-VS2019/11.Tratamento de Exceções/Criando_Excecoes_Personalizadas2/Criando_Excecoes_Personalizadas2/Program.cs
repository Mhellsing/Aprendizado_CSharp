using System;
using Criando_Excecoes_Personalizadas2.Entities;
namespace Criando_Excecoes_Personalizadas2
{
    class Program
    {
        static void Main(string[] args)
        {
            //solução ruim
            Console.Write("Room Number: ");
            var roomNumber = int.Parse(Console.ReadLine());

            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());

            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
            }
            else
            {
                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine($"Reservation{reservation}\n");

                Console.WriteLine("Enter data to update the reservation");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                string error = reservation.UpdateDates(checkIn, checkOut);

                if (error != null)
                {
                    Console.WriteLine($"Error in reservation:{error}");
                }
                else
                {
                    Console.WriteLine($"Reservation:{reservation}");
                }
            }
        }
    }
}
