using System;
using System.Collections.Generic;
using System.Text;

namespace Exam70_483
{
    class _2_2_TestBoxingAndUnboxing
    {

        public static void RunBoxingAndUnboxing()
        {

            object o = 99.99; //value 99 is boxed into an object

            double oVal = (double)o; //the boxed object is *unboxed* back into an int

            Console.WriteLine("OVal is: {0}  ", oVal);
            Console.ReadLine();



        }
      
      
    }

   
   
}
