using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Exam70_483
{
    class TestContinuationTasks
    {

       public static void RunTestContinuationTask()
        {
            Task<string> task1 = Task.Run(() =>
            {
                return 12;
            }).ContinueWith((antecedent) =>
            {
                return $"The Square of {antecedent.Result} is: {antecedent.Result * antecedent.Result}";
            });
            Console.WriteLine(task1.Result);

            Console.ReadKey();
        }

        public static void RunTestContinueWith()
        {
            Task<int> task = Task.Run(() =>
           {
               return 10;
           });

            task.ContinueWith((i) =>
            {
                Console.WriteLine("task canceled");
            }, TaskContinuationOptions.OnlyOnCanceled);

            task.ContinueWith((i) =>
            {
                Console.WriteLine("task faulted");
            }, TaskContinuationOptions.OnlyOnFaulted);

            var completedTask = task.ContinueWith((i) =>
            {
                Console.WriteLine("task completed");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            completedTask.Wait();
            Console.ReadLine();


        }
            

    }
}
