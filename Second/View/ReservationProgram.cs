using System;
using System.Collections.Generic;
using System.Text;
using Second.Entities.Reservations;
using Second.Entities.Exceptions;

namespace Second.View
{
    class ReservationProgram
    {
        
        public static void Display ()
        {
            try
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
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
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
