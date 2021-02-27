using System;
using System.Collections.Generic;
using System.Text;
using Second.Entities.TaxPayer;
using System.Globalization;

namespace Second.View
{
    class TaxPayerProgram
    {
        public static void Display()
        {
            Console.Write("Enter the number of tax payers: ");
            int numberOfTaxPayers = int.Parse(Console.ReadLine());
            double totalTaxes = 0.0;

            List<TaxPayer> taxPayers = new List<TaxPayer>();

            for (int i = 0; i < numberOfTaxPayers; i++)
            {
                Console.WriteLine($"Tax payer#{i + 1} data:");
                Console.Write("Individual or company (i/c)? ");
                string taxPayerType = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual Income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (taxPayerType == "i")
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxPayers.Add(new Individual(name, annualIncome, healthExpenditures));
                }
                else if (taxPayerType == "c")
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    taxPayers.Add(new Individual(name, annualIncome, numberOfEmployees));
                }
                else
                {
                    Console.WriteLine("NO SUCH TYPE");
                }
            }

            Console.WriteLine("TAXES PAID: ");
            foreach (TaxPayer taxPayer in taxPayers)
            {
                Console.WriteLine(taxPayer.ToString());
                totalTaxes += taxPayer.Tax();
            }
            Console.WriteLine("TOTAL TAXES: $ " + totalTaxes.ToString("F2"));

        }
    }
}
