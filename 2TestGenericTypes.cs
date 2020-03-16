using System;
using System.Collections.Generic;
using System.Text;

namespace Exam70_483
{
    class _2TestGenericTypes
    {
        //Program creates MyStack that can hold strings

      public  class MyStack<T>
        {
            int stackTop = 1;
            T[] items = new T[100];

            public void Push (T item)
            {
                if (stackTop == items.Length)
                {
                    throw new Exception("Stack full");
                }
                items[stackTop] = item;
                stackTop++;

            }
             public T Pop()
            {
                if (stackTop == 0)
                {
                    throw new Exception("Stack empty");
                }

                stackTop--;
                return items[stackTop];

            }

           

        }

        public static void RunGenericTypes()
        {
            MyStack<string> nameStack = new MyStack<string>();
            nameStack.Push("Anne");
            nameStack.Push("Mark");

            Console.WriteLine(nameStack.Pop());
            Console.WriteLine(nameStack.Pop());
            Console.ReadLine();
        }


    }
}
