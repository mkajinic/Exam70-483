using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Exam70_483
{
    class TestParallelInvoke
    {


        static void DoSomeTask(int number)
        {
            Console.WriteLine($"DoSomeTask {number} started by Thread {Thread.CurrentThread.ManagedThreadId}");
            //Sleep for 2000 milliseconds
            Thread.Sleep(2000);
            Console.WriteLine($"DoSomeTask {number} completed by Thread {Thread.CurrentThread.ManagedThreadId}");
        }


        public static void RunTestParallellInvoke()
        {

            Parallel.Invoke(
                    () => DoSomeTask(1),
                    () => DoSomeTask(2),
                    () => DoSomeTask(3),
                     () => DoSomeTask(4)
                     );
            Console.ReadKey();

        }

        /* Output
         * 
         *  DoSomeTask 2 started by Thread 5
            DoSomeTask 1 started by Thread 1
            DoSomeTask 3 started by Thread 6
            DoSomeTask 4 started by Thread 4
            DoSomeTask 3 completed by Thread 6
            DoSomeTask 1 completed by Thread 1
            DoSomeTask 4 completed by Thread 4
            DoSomeTask 2 completed by Thread 5

         * 
         * */




    }
}
