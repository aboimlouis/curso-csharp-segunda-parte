using System;
using Second.Entities;
using Second.Entities.Enums;
using Second.View;


namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            Console.WriteLine("Please choose an option: ");
            Console.WriteLine("1 - Worker Program");
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                WorkerProgram.Display();
            }
            else
            {
                Console.WriteLine("This option does not exist.");
            }
        }
    }
}
