using System;
using System.Collections.Generic;
using System.Text;

namespace Exam70_483
{
    class _2TestGenericTypes
    {
        //Program creates MyStack that can hold strings
        /// <summary>
        /// example defines a generic class, GFG, which uses a generic type parameter ‘T’.
        /// Just as a method can take one argument, generics can take various parameters. One argument can be passed as a familiar type and other as a generic type,
        /// </summary>
        /// <typeparam name="T"></typeparam>

        // We use < > to specify Parameter type
        public class MyStack<T>
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
        //************************************************************************************************
        public class Geeks //generics can take various parameters
        {
            public void Display <TypeOfValue>(string msg, TypeOfValue value)
            {
                Console.WriteLine("{0}:{1}", msg, value);
            }
        }








        public static void RunGenericTypes()
        {
            // instance of string type 
            MyStack<string> nameStack = new MyStack<string>();
            nameStack.Push("Anne");
            nameStack.Push("Mark");

            Console.WriteLine(nameStack.Pop());
            Console.WriteLine(nameStack.Pop());


            
        }


    }
}
