using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam70_483
{
    class TestCancelATask
    {

        //  ** Thread can be stopped anytime but TASK must monitor cancellation token so it will end when told to

        static CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        static void Clock()
        {
            while (!cancellationTokenSource.IsCancellationRequested)
            {
                Console.WriteLine("\nTick");
                Thread.Sleep(500);
                Console.WriteLine("Tock");
                Thread.Sleep(500);
            }
        }

   
 

        public static void RunTestCanacelTask()
        {
            Task.Run(() => Clock());
            Console.WriteLine("Press any key to stop the clock");
            Console.ReadLine();

            cancellationTokenSource.Cancel();
            Console.WriteLine("Clock stopped");

            Console.ReadLine();
        }


    }
}
