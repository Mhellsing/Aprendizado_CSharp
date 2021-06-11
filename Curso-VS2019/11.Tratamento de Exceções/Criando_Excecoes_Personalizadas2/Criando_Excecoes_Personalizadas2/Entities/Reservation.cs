using System;
namespace Criando_Excecoes_Personalizadas2.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            //a lógica de verificação de erro passou para uma função retornando string,
            //entretanto a semântica ainda está errada, pois a função deveria somente atualizar as datas,
            //o que torna uma solução ruim (gambiarra);
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                return "Reservation dates for update must be futures dates";
            }
            if (checkOut <= checkIn)
            {
                return "Check-out date must be after check-in date";
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
            return null;
        }

        public override string ToString()
        {
            return $"Romm: {RoomNumber}, Check-in: {CheckIn.ToString("dd/MM/yyyy")}, Check-out: {CheckOut.ToString("dd/MM/yyyy")}, {Duration()} nights.";
        }
    }
}
