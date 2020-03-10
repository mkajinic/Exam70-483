using System;
using System.Collections.Generic;
using System.Text;

namespace Exam70_483
{
    class TestExceptionObject
    {

        public static void RunExceptionObject()
        {

            try
            {
                Console.Write("Enter an integer: ");
                string numbText = Console.ReadLine();
                int result;

                result = int.Parse(numbText);
                Console.WriteLine("YOu have entered {0}", result);

                int sum = 1 / result;
                Console.WriteLine("Sum is {0}", sum);
            }

            catch (NotFiniteNumberException nx)
            {
                Console.WriteLine("Invalid number");
            }

            catch (DivideByZeroException zx)
            {
                Console.WriteLine("Divide by zero");
            }


            catch (Exception ex)
            {

                Console.WriteLine("That's not a number!");
                Console.WriteLine("Message: " + ex.Message);
                Console.WriteLine("StackTrace: " + ex.StackTrace);
                Console.WriteLine("HelpLink: " + ex.HelpLink);
                Console.WriteLine("Target Site: " + ex.TargetSite);
                Console.WriteLine("Source: " + ex.Source);

            }
            finally
            {
                Console.WriteLine("That's all!");
            }

            Console.ReadLine();

        }

    }
}
