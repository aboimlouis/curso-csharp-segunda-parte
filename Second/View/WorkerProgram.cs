using System;
using System.Collections.Generic;
using System.Text;
using Second.Entities;
using Second.Entities.Enums;
using System.Globalization;
namespace Second.View
{
    class WorkerProgram
    {
        public static void Display()
        {

            Console.Write("Enter Department's name: ");
            string deptName = Console.ReadLine(); //Alterei, pois imagino que depois seja ideal separar o view da criação de objetos (?)

            Console.WriteLine("Enter worker data -");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.Write("How many contracts to this worker: ");
            int numberOfContracts = int.Parse(Console.ReadLine());

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            for(int i = 0; i < numberOfContracts; i++)
            {
                DateTime date;
                double valuePerHour;
                int hours;

                Console.WriteLine($"Enter #{i+1} contract data:");

                Console.Write("Date (DD/MM/YYYY): ");
                date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                valuePerHour = double.Parse(Console.ReadLine());

                Console.Write("Duration (hours): ");
                hours = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                worker.AddContract(new HourContract(date, valuePerHour, hours)); //ele separa a criação do objeto contract e a adição dele na lista
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            DateTime calculateIncomeDate = DateTime.Parse(Console.ReadLine());


            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " 
                + calculateIncomeDate.Month + "/" + calculateIncomeDate.Year + ": " 
                + worker.Income(calculateIncomeDate.Year, calculateIncomeDate.Month).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
