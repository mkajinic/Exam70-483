using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exam70_483
{
    class TestLocking
    {
        static long sharedTotal;

        static int[] items = Enumerable.Range(0, 500000000).ToArray();

        static object sharedTotalLock = new object();

        public static void RunTestLocking(int start, int end)
        {
            while (start < end)
            {
              
                lock (sharedTotalLock)
                {
                    sharedTotal = sharedTotal + items[start];
                }
                start++;
        
            }
            Console.WriteLine("total is: {0}", sharedTotal);
            Console.ReadLine();
        }
        

    }
}
