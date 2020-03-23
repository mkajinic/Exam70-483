using System;
using System.Collections.Generic;
using System.Text;

namespace Exam70_483
{
    class _2_2_TestGetEnumerator
    {

        public static void RunGetEnumerator()
        {
            var stringEnumerator = "Hello world".GetEnumerator();

            while (stringEnumerator.MoveNext())
            {
                Console.WriteLine(stringEnumerator.Current);
            }


            foreach (char item in "Hello World")
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }


    }
}
