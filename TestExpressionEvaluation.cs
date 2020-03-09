using System;
using System.Collections.Generic;
using System.Text;

namespace Exam70_483
{
    class TestExpressionEvaluation
    {
        public static void RunExpressionEvaluation()
        {
            int i = 6;

            i++; // monadic ++ operator increment  - i is now 1
            i--; // -- operator decrement          - i is now 0

            //Postfix monadic operator - perform after value given
            Console.WriteLine(i++); // writes 6, and sets i to 7               

            //Prefix monadic operator -perform before value is given            
            Console.WriteLine(++i); // writes 8                 

           Console.WriteLine(i++); // writes 8                    

            Console.ReadLine();
        }

        
       

    }
}
