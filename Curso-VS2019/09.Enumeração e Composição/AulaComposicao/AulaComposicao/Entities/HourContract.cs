    using System;
namespace AulaComposicao.Entities
{
    class HourContract
    {
        public DateTime Date{ get; set; }
        public double ValuePerHour { get; set; }
        public int Hour { get; set; }

        public HourContract()//Construtor padrão
        {
        }

        public HourContract(DateTime date, double valuePerHour, int hour)//Construtor
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hour = hour;
        }

        public double TotalValue()
        {
            return ValuePerHour * Hour;
        }
    }
}
