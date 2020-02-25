using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Exam70_483
{
    class TestBlockingCollection
    {

        public static void RunBlockingCollection()
        {
            //Blocking collection that can hold 5 items
          //  BlockingCollection<int> data = new BlockingCollection<int>(5);

            //items will be taken on the basis first in first out
            BlockingCollection<int> data = new BlockingCollection<int>(new ConcurrentStack<int>(), 5);

            Task.Run(() =>
            {
                for (int i = 0; i < 11; i++)
                {
                    data.Add(i);
                    Console.WriteLine("Data {0} added succesfully. ", i);
                }
                data.CompleteAdding();
            });

            Console.ReadLine();
            Console.WriteLine("**Reading collection**");


            Task.Run(() =>
            {
                while (!data.IsCompleted) // determines wether to stop taking items from collection
                {
                    try
                    {
                        int v = data.Take();
                        Console.WriteLine("Data {0} taken succesfully", v);
                    }
                    catch (InvalidOperationException)
                    {

                     
                    }
                }
            });

            Console.ReadLine();
        }


    }
}
