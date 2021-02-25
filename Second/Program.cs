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
            Console.WriteLine("4 - INHERITANCE - Orders (Exercício Proposto)");

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
            else
            {
                Console.WriteLine("This option does not exist.");
            }
        }
    }
}
