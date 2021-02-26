using System;
using System.Collections.Generic;
using System.Text;

namespace Second.Entities.Account
{
    sealed class SavingsAccount : Account //sealed determina que não é possível herdar
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }


        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
            //Balance -= amount;
        }
        //SEALED em método só funciona em override, evita de ser usado por coisas herdadas

    }
}
