using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam70_483
{
    class TestParallelFor
    {
        public static void RunParallelFor()
        {
            //Limiting the maximum degree of parallelism to 2
            var options = new ParallelOptions()
            {
                MaxDegreeOfParallelism = 2
            };
            int n = 10;
            Parallel.For(0, n, options, i =>
            {
                Console.WriteLine(@"value of i = {0}, thread = {1}",
                i, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            });
            Console.WriteLine("Press any key to exist");
            Console.ReadLine();

            //As we set the degree of parallelism to 2. So, a maximum of 2 threads is used to execute the code that we can see from the above output.
        }

    }
}
