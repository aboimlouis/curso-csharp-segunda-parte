using System;
using System.Collections.Generic;
using System.Text;

namespace Second.Entities.TaxPayer
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company()
        {
        }

        public Company(String name, Double annualIncome, int numberOfEmployees) : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10)
            {
                return AnnualIncome * 0.14;
            }
            else
            {
                return AnnualIncome * 0.16;
            }
        }
    }
}
