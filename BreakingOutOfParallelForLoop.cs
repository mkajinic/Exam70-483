using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam70_483
{
    class BreakingOutOfParallelForLoop
    {
        public static void RunBreakingOutOfParallelForLoop()
        {

            var BreakSource = Enumerable.Range(0, 1000).ToList();
            int BreakData = 0;
            Console.WriteLine("Using loopstate Break Method");
            Parallel.For(0, BreakSource.Count, (i, BreakLoopState) =>
            {
                BreakData += i;
                if (BreakData > 100)
                {
                    BreakLoopState.Break();
                    Console.WriteLine("Break called iteration {0}. data = {1} ", i, BreakData);
                    
                }
            });
            Console.WriteLine("Break called data = {0} ", BreakData);
            var StopSource = Enumerable.Range(0, 1000).ToList();
            int StopData = 0;
            Console.WriteLine("Using loopstate Stop Method");
            Parallel.For(0, StopSource.Count, (i, StopLoopState) =>
            {
                StopData += i;
                if (StopData > 100)
                {
                    StopLoopState.Stop();
                    Console.WriteLine("Stop called iteration {0}. data = {1} ", i, StopData);
                }
            });
            Console.WriteLine("Stop called data = {0} ", StopData);
            Console.ReadKey();

            //In a Parallel.For or Parallel.ForEach loop, you cannot use the same break or Exit statement that is used in a sequential loop because those language constructs are valid for loops, and a parallel “loop” is actually a method, not a loop. Instead, you use either the Stop or Break method.

            //Iterator will not instantly stop when reaches 100

        }

    }
}
