using System;
using System.Collections.Generic;
using System.Text;

namespace Second.Entities.Account
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public void Loan(double amount)
        {

        }
    }
}
