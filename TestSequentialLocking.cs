using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Exam70_483
{
    class TestSequentialLocking
    {
        static object lock1 = new object();
        static object lock2 = new object();

        static void Method1()
        {
            lock (lock1)
            {
                Console.WriteLine("Method 1 got Lock 1");
                Console.WriteLine("Method 1 waiting for Lock 2");

                lock (lock2)
                {
                    Console.WriteLine("Method 1 got Lock 2");

                }
                Console.WriteLine("Method 1 released Lock 2");
            }
            Console.WriteLine("Method 1 released Lock 1");

        }


        static void Method2()
        {
            lock (lock2) //*should not nest lock inside another
            {
                Console.WriteLine("***********************");
                Console.WriteLine("Method 2 got Lock 2");
                Console.WriteLine("Method 2 waiting for Lock 1");

                lock (lock1)
                {
                    Console.WriteLine("Method 2 got Lock 2");

                }
                Console.WriteLine("Method 2 released Lock 1");
            }
            Console.WriteLine("Method 2 released Lock 2");

        }


        public static void RunTestSequentialLocks()
        {
            #region Deadlock Tasks
            //Tasks in this case never complete, each is waiting for others lock object and neither can continue
            Task t1 = Task.Run(() => Method1());
            Task t2 = Task.Run(() => Method2());

            Console.WriteLine("Waiting for task 2");
            t2.Wait();
            #endregion



            #region Sequential locking
            //Program runs to completion. each method gets the locks objects in turn
            // Method1();
            //  Method2();
            #endregion

            Console.WriteLine("Methods complete. :)");
            Console.ReadLine();
        }


    }
}
