using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam70_483
{
    class TestParallelForEach
    {
      public static void RunTestParallelForEach()
        {
            List<int> integerList = Enumerable.Range(0, 10).ToList();
        Parallel.ForEach(integerList, i =>
            {
                Console.WriteLine(@"value of i = {0}, thread = {1}",
                    i, Thread.CurrentThread.ManagedThreadId);
            });

            Console.WriteLine("Press any key to exist");
            Console.ReadLine();
        }
    }
}
