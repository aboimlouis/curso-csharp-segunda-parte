using System;
using System.Collections.Generic;
using System.Text;

namespace Second.Entities.Account
{
    class SavingsAccount : Account
    {
        public double Interest { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interest) : base(number, holder, balance)
        {
            Interest = interest;
        }


        public void UpdateBalance()
        {

        }
    }
}
