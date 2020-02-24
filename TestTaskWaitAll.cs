using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Exam70_483
{
    class TestTaskWaitAll
    {
        //task.WaitAll can be used to pause a program until a number of tasks have completed

        public static void DoWork(int i)
        {
            Console.WriteLine("Task {0} starting", i);
            Thread.Sleep(2000);
            Console.WriteLine("Task {0} finished", i);

        }

        public static void RuntTaskWaitAll()
        {
            Task[] SomeTasks = new Task[10];

            for (int i = 0; i < 10; i++)
            {
                int taskNum = i; //if variable i was used in lambda expression all tasks would have number 10 limit value of the loop

                SomeTasks[i] = Task.Run(() => DoWork(taskNum)); 
            }

            Task.WaitAll(SomeTasks);

            Console.WriteLine("Finished processing");
            Console.ReadLine();
        }
    }
}
