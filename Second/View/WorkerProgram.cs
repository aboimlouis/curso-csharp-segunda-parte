using System;
using System.Collections.Generic;
using System.Text;
using Second.Entities;
using Second.Entities.Enums;

namespace Second.View
{
    class WorkerProgram
    {
        public static void Display()
        {
            string name;
            Department department;
            WorkerLevel level;
            double baseSalary;
            int numberOfContracts;
            DateTime calculateIncomeDate;


            Console.Write("Enter Department's name: ");
            department = new Department(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter worker data:");

            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Base salary: ");
            baseSalary = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("How many contracts to this worker: ");
            numberOfContracts = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Worker worker = new Worker(name, level, baseSalary, department);

            for(int i = 0; i < numberOfContracts; i++)
            {
                DateTime date;
                double valuePerHour;
                int hours;

                Console.WriteLine("Enter #" + i + " contract data:");

                Console.Write("Date (DD/MM/YYYY): ");
                date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Value per hour: ");
                valuePerHour = double.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Duration (hours): ");
                hours = int.Parse(Console.ReadLine());
                Console.WriteLine();

                worker.AddContract(new HourContract(date, valuePerHour, hours));
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            calculateIncomeDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Income for " + calculateIncomeDate + ": " + worker.Income(calculateIncomeDate.Year, calculateIncomeDate.Month));

        }
    }
}
