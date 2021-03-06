﻿using System;
using System.Collections.Generic;
using System.Text;
using Second.Entities.Exceptions;

namespace Second.Entities.Reservations
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
                throw new DomainException("Check-out date must be after check-in date.");
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(100);
            sb.Append("Reservation: ");
            sb.Append("Room ");
            sb.Append(RoomNumber.ToString());
            sb.Append(", Check-in: ");
            sb.Append(CheckIn.ToString("dd/MM/yyyy"));
            sb.Append(", Check-out: ");
            sb.Append(CheckOut.ToString("dd/MM/yyyy"));
            sb.Append(", ");
            sb.Append(Duration().ToString());
            sb.Append(" nights.");
            return sb.ToString();
        }

        internal void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime nowDate = DateTime.Now;
            if (checkIn < nowDate || checkOut < nowDate)
            {
                throw new DomainException("Reservation dates for update must be future dates.");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in date.");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }
    }
}
