using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Exam70_483
{
    class TestThreadContext
    {

        public static void DisplayThread(Thread t)
        {
            Console.WriteLine("Name: {0}", t.Name);
            Console.WriteLine("Culture: {0}", t.CurrentCulture);
            Console.WriteLine("Priority: {0}", t.Priority);
            Console.WriteLine("Context: {0}", t.ExecutionContext);
            Console.WriteLine("Backround: {0}", t.IsThreadPoolThread);

        }

        public static void RunThreadContext()
        {
            Thread.CurrentThread.Name = "MainMethod";
            DisplayThread(Thread.CurrentThread);
        }


    }
}
