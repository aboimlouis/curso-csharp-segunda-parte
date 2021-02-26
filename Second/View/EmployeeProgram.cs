using System;
using System.Collections.Generic;
using System.Text;
using Second.Entities.Employee;
using System.Globalization;

namespace Second.View
{
    class EmployeeProgram
    {
        public static void Display()
        {

            Console.Write("Enter the number of employees: ");
            int numberOfEmployees = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.WriteLine("Employee #" + (i + 1) + ":");
                Console.Write("Outsourced (y/n): ");
                string outsourced = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (outsourced == "y")
                {
                    Console.Write("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else if (outsourced == "n") 
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }
                else
                {
                    Console.WriteLine("Invalid input for outsource.");
                }
            }

            Console.WriteLine("PAYMENTS:");
            foreach (Employee employee in employees) 
            {
                Console.WriteLine(employee.ToString());
            }
            
        }
    }
}
