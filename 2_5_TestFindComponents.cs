using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Linq;

namespace Exam70_483
{
    class _2_5_TestFindComponents
    {


        public interface IAccount
        {
            void PayInFunds(decimal amount);
            bool WithdrawFunds(decimal amount);
            decimal GetBalance();
        }

        public class BankAccount : IAccount
        {
            protected decimal balance = 0;

            public virtual bool WithdrawFunds(decimal amount)
            {
                if (balance < amount)
                {
                    return false;
                }
                balance = balance - amount;
                return true;
            }

            void IAccount.PayInFunds(decimal amount)
            {
                balance = balance + amount;
            }

            decimal IAccount.GetBalance()
            {
                return balance;
            }
        }

        public class BabyAccount : BankAccount, IAccount
        {
            public override bool WithdrawFunds(decimal amount)
            {
                if (amount > 10)
                {
                    return false;
                }

                if (balance < amount)
                {
                    return false;
                }
                balance = balance - amount;
                return true;
            }
        }




        //using IsAssignable method t decide wearher or not given type implemnets the IAccount interface
        public static void RunFindComponents()
        {

            Assembly thisAssembly = Assembly.GetExecutingAssembly();

            List<Type> AccountTypes = new List<Type>();

            foreach (Type t in thisAssembly.GetTypes())
            {
                if (t.IsInterface)
                    continue;

                if (typeof(IAccount).IsAssignableFrom(t)) 
                {
                    AccountTypes.Add(t);
                }
            }

            foreach (Type t in AccountTypes)
                Console.WriteLine(t.Name);

            Console.ReadKey();
        }


    }



    


}
