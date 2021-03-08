using System;
using System.Collections.Generic;
using System.Text;
using Second.Entities.Reservations;

namespace Second.View
{
    class ReservationProgram
    {
        public static void Display ()
        {
            Console.WriteLine("Create the reservation: ");
            Console.WriteLine("Room number: ");
            int roomNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);

            Console.WriteLine(reservation.ToString());
            UpdateReservation(ref reservation);
        }

        public static void UpdateReservation(ref Reservation reservation)
        {
            Console.WriteLine();
            Console.WriteLine("Update the reservation dates: ");
            Console.WriteLine("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            reservation.UpdateDates(checkIn, checkOut);
        }
    }
}
