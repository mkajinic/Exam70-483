using System;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;
using System.Collections.Generic;

namespace Exam70_483
{
    class Program
    {

        static void Main()
        {

            // TestParallelInvoke.RunTestParallellInvoke();
            // TestParallelForEach.RunTestParallelForEach();
            //  TestParallelFor.RunParallelFor();
            // BreakingOutOfParallelForLoop.RunBreakingOutOfParallelForLoop();
            // TestTaskReturningValue.RunTaskReturningValue();
            //TestTaskWaitAll.RuntTaskWaitAll();
            // TestContinuationTasks.RunTestContinuationTask();
            // TestContinuationTasks.RunTestContinueWith();
            //  TestThreadAbortWithSharedFlag.RunThreadAbortWithSharedFlag();
            // TestThreadContext.RunThreadContext();
            //TestThreadPools.RunThereadPools();
            // TestBlockingCollection.RunBlockingCollection();
            //  TestConcurent.RunConcurentBag();
            //TestLocking.RunTestLocking(0,50000000);
            TestSensibileLocking.RunTestLocking2(0, 50000000);





        }








    }
}
