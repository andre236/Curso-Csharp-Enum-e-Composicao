﻿using TratamentoExcecoes.Entities.Exceptions;

namespace TratamentoExcecoes.Entities
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
            if (checkOut <= checkIn)
            {
                throw new DomainException("Erro na reserva! o Checkout precisa ser maior que checkIn");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
               throw new DomainException("Erro na reserva. As datas da reserva tem que ser datas futuras");
            }
            
            if (checkOut <= checkIn)
            {
                throw new DomainException("Erro na reserva! o Checkout precisa ser maior que checkIn");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + " , check-in: "
                + CheckIn.ToString("dd/MM/YYYY")
                + " , Check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }


    }
}
