using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Exam70_483
{
    class TestThreadPools
    {
        // ThreadPool restricts the number of active threads and maintains a Q of threads waiting to execute

        public void one(object o)
        {
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("One executed");
            }
        }
        public void two(object o)
        {
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("Two executed");
            }
        }
        public void three(object o)
        {
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("Three executed");
            }
        }
       public static void RunThereadPools()
        {
            TestThreadPools d = new TestThreadPools();
            for (int i = 0; i < 3; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(d.one));
                ThreadPool.QueueUserWorkItem(new WaitCallback(d.two));
                ThreadPool.QueueUserWorkItem(new WaitCallback(d.three));
            }
            Console.Read();
        }

    }
}
