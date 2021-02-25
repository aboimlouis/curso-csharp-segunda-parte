using System;
using System.Collections.Generic;
using System.Text;
using Second.Entities.Account;

namespace Second.View
{
    class AccountProgram
    {
        public static void Display()
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);
            SavingsAccount sacc = new SavingsAccount(1003, "John", 0.0, 0.01);

            //upcasting

            Account acc1 = bacc;
            Account acc2 = sacc;

            //downcasting, somente quando for necessário, por ser inseguro

            BusinessAccount bacc2 = (BusinessAccount)acc1; //requer explicit casting

            if (acc2 is BusinessAccount) //tentar descobrir de a Account com dados de BusinessAccount é segura 
            {
                bacc2 = (BusinessAccount)acc2;
                //bacc2 = acc2 as BusinessAccount; forma alternativa de sintaxe
            }
            else
            {
                Console.WriteLine("Incompatible");
            }

        }
    }
}
