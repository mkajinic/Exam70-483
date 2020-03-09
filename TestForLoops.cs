using System;
using System.Collections.Generic;
using System.Text;

namespace Exam70_483
{
    class TestForLoops
    {

        static int counter;
        
         static void Initilize()
        {
            Console.WriteLine("Innitilize called");
            counter = 0;
        }

         static void Update()
        {
            Console.WriteLine("Update called");
            counter = counter + 1;
        }


         static bool Test()
        {
            Console.WriteLine("\nTest called");
            return counter < 5;
        }


        public static void RunTestForLoops()
        {
            for (Initilize(); Test(); Update())
            {
                Console.WriteLine("hELLO {0}", counter);
            }

            for (int counter = 0; counter < 5; counter++)
            {
                Console.WriteLine("hELLO {0}", counter);
            }

            Console.ReadLine();
        }
    }
}
