using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;


namespace Exam70_483
{
    class TestConcurent
    {
        public static void RunConcurentBag()
        {
            //ConcurrentQueue - first in first out data store
            ConcurrentQueue<string> queue = new ConcurrentQueue<string>();

            queue.Enqueue("rob");
            queue.Enqueue("miles");
            string str;

            if (queue.TryPeek(out str))
            {
                Console.WriteLine("Queue:");
                Console.WriteLine("Peek: {0}", str);
            }

            if (queue.TryDequeue(out str))
            {
                Console.WriteLine("Queue:");
                Console.WriteLine("Dequeue: {0}", str);
            }
          


            //ConcurrentStack - last in first out data store
            ConcurrentStack<string> stack = new ConcurrentStack<string>();

            stack.Push("rob");
            stack.Push("miles");
            string word ;
          

            if (stack.TryPeek(out word))
            {
                Console.WriteLine("Stack:");
                Console.WriteLine("Peek: {0}", word);
            }

            if (stack.TryPop(out word))
            {
                Console.WriteLine("Stack::");
                Console.WriteLine("Pop: {0}", word);
            }



            //ConcurrentBag - store in bag when order in which items are added is not important
            ConcurrentBag<string> bag = new ConcurrentBag<string>();

            bag.Add("Pinokio");
            bag.Add("Stranger Things");
            bag.Add("Pikachu");
            bag.Add("macka");

            string myString;


            if (bag.TryPeek(out myString))
            {
                Console.WriteLine("Bag:");
                Console.WriteLine("Peek: {0}", myString);
            }

            if (bag.TryTake(out myString))
            {
                Console.WriteLine("Bag:");
                Console.WriteLine("Take: {0}", myString);
            }

            Console.ReadLine();

            ConcurrentDictionary<string, int> ages = new ConcurrentDictionary<string, int>();
            if (ages.TryAdd("Milhouse", 12))
            {
                Console.WriteLine("Milhouse added succesfully.");
                Console.WriteLine("Milhouse's age: {0}", ages["Milhouse"]);
            }

            if (ages.TryUpdate("Milhouse", 13, 12)) //Set milhouse age to 22 if its 21
            {
                Console.WriteLine("Milhouse age updated succesfully.");
               
                Console.WriteLine("Milhouse's new age: {0}", ages["Milhouse"]);

                Console.WriteLine("age updated as {0}", ages.AddOrUpdate("Milhouse", 1, (name, age) =>
                 age = age + 1));
                  

                //Console.WriteLine("MIlhouse NEW age : {0} ", ages["Rob"]);
            }


        }

    }
}
