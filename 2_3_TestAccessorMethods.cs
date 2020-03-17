using System;
using System.Collections.Generic;
using System.Text;

namespace Exam70_483
{
    class _2_3_TestAccessorMethods
    {

        class BankAccount
        {

            private decimal accountBalance = 0;

            public void PayIn(decimal amountToPayIn)
            {
                accountBalance = accountBalance + amountToPayIn;
            }

            public bool WithdrawFunds(decimal amountToWithdraw)
            {
                if (amountToWithdraw > accountBalance)
                {
                    Console.WriteLine("You dont have enough!");
                    return false;
                }

                accountBalance = accountBalance - amountToWithdraw;
                return true;
               

            }

            public decimal GetBalance()
            {
                return accountBalance;
            }


          


        }


        public static void RunAccessorMethods()
        {
            BankAccount a = new BankAccount();
            a.PayIn(50);
            Console.WriteLine("Pay in 50");

       
            if (a.WithdrawFunds(40))
            {
                Console.WriteLine("withdraw 40");
            }

            Console.WriteLine("Account balance is {0} ", a.GetBalance());
            Console.ReadLine();
        }


    }
}
