using System;
using System.Collections.Generic;
using System.Text;

namespace Second.Entities.TaxPayer
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public TaxPayer()
        {
        }
        protected TaxPayer(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Tax();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(": $ ");
            sb.Append(Tax().ToString("F2"));
            return sb.ToString();
        }
    }
}
