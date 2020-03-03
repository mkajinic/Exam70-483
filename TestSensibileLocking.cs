using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exam70_483
{
    class TestSensibileLocking
    {
        static long sharedTotal;

        static int[] items = Enumerable.Range(0, 500000000).ToArray();

        static object sharedTotalLock = new object();

        public static void RunTestLocking2(int start, int end)
        {
            while (start < end)
            {
                long subTotal = 0;
                while (start < end)
                {
                    subTotal = subTotal + items[start];
                        start++;
                }

                lock (sharedTotalLock)
                {
                    sharedTotal = sharedTotal + subTotal;
                }
             
            }
            Console.WriteLine("total is: {0}", sharedTotal);
            Console.ReadLine();
        }

    }
}
