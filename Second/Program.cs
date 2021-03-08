using System;
using Second.Entities.Worker;
using Second.Entities.Enums.Worker;
using Second.View;


namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            Console.WriteLine("Please choose an option: ");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - ENUMS - Worker"); //Aula 119 a 121
            Console.WriteLine("2 - ENUMS - Post"); // Aula 122
            Console.WriteLine("3 - ENUMS - Orders (Exercício Proposto)"); //Aula 123
            Console.WriteLine("4 - INHERITANCE - Herança");
            Console.WriteLine("5 - INHERITANCE - Employee (Exercício Resolvido)"); //aula 131
            Console.WriteLine("6 - INHERITANCE - Product (Exercício Proposto)"); //aula 133
            Console.WriteLine("7 - INHERITANCE - Shapes (Exercício Resolvido)"); //aula 136
            Console.WriteLine("8 - INHERITANCE - TaxPayer (Exercício Proposto)"); //aula 137
            Console.WriteLine("9 - EXCEPTIONS - Reservation (Exercício Proposto)"); //aula 143 a 145

            option = int.Parse(Console.ReadLine());
            if (option == 0)
            {
                Console.WriteLine("Exiting.");
            }
            else if (option == 1)
            {
                WorkerProgram.Display();
            }
            else if (option == 2)
            {
                PostProgram.Display();
            }
            else if (option == 3)
            {
                OrdersProgram.Display();
            }
            else if (option == 4)
            {
                AccountProgram.Display();
            }
            else if (option == 5)
            {
                EmployeeProgram.Display();
            }
            else if (option == 6)
            {
                ProductProgram.Display();
            }
            else if (option == 7)
            {
                ShapesProgram.Display();
            }
            else if (option == 8)
            {
                TaxPayerProgram.Display();
            }
            else if (option == 9)
            {
                ReservationProgram.Display();
            }
            else
            {
                Console.WriteLine("This option does not exist.");
            }
        }
    }
}
