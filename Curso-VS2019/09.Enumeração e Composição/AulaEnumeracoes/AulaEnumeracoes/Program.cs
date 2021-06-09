using AulaEnumeracoes.Entities;
using AulaEnumeracoes.Entities.Enums;
using System;

namespace AulaEnumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);
            //Convertendo o tipo enumerado para string
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            //Convertendo a string para tipo enumerado
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}
