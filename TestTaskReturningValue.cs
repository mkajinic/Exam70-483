using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam70_483
{
    class TestTaskReturningValue
    {

        public static int CalculateResult()
        {

            Console.WriteLine("Work starting");
            Thread.Sleep(2000);
            Console.WriteLine("Work finished");
            return 99;

        }

        public static void RunTaskReturningValue()
        {
            Task<int> task = Task.Run(() =>
            {
                return CalculateResult();
            });

            Console.WriteLine(task.Result);
            Console.WriteLine("Finished processing.");
            Console.ReadKey();
            
        }


    }
}
