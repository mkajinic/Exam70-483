using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Exam70_483
{
    class _3_1_ValidateRegularExpressions
    {
        public static void RunRegularExpressions()
        {
            string input = "Rob Miles:My Way:120";

            string regexToMatch = "."; //match one or more characters

            //isMatch method returns true if the regular expressioon mathhes a substring in the string being tested
            if (Regex.IsMatch(input, regexToMatch))//returns bool
            {
                Console.WriteLine("Valid music track description");
            }
            else
            {
                Console.WriteLine("Invalid music track");
            }

            //test tryParse
            int result = 99;
            if (int.TryParse("99", out result))
            {
                Console.WriteLine("this is a valid number");
            }
            else
            {
                Console.WriteLine("Not a valid number");
            }



            //using convert 
            string stringValue = "85";
            int intValue = Convert.ToInt32(stringValue);

            Console.WriteLine("\nintValue: {0} ", intValue);

           string  someString = "true";
            bool boolValue = Convert.ToBoolean(someString);
            Console.WriteLine("boolValue: {0} ", boolValue);




            Console.ReadKey();
        }

    }
}
