using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Exam70_483
{
    class TestThreadAbortWithSharedFlag
    {

       public static bool tickRunning; //flag variable

        public static void RunThreadAbortWithSharedFlag()
        {
            tickRunning = true;

            Thread tickTread = new Thread(() =>
           {
               while (tickRunning)
               {
                   Console.WriteLine("Tick");
                   Thread.Sleep(1000);
               }
           });

            tickTread.Start();

            Console.WriteLine("Press a key to stop the clock");
            Console.ReadLine();
            tickRunning = false;
            Console.WriteLine("press to exit");
            Console.ReadLine();
               
        }


    }
}
