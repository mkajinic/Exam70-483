using System;
using System.Collections.Generic;
using System.Text;

namespace Exam70_483
{
    class TestCustomExceptions
    {
         
        class CalcException : Exception
        {
            public enum CalcErrorCodes
            {
                InvalidNumberText, DivideByZero
            }

            public CalcErrorCodes Error { get; set; }

             public CalcException (string message, CalcErrorCodes error) : base(message)
            {
                Error = error;
            }


           

        }

        public static void RunCustomExceptions()
        {
            try
            {
                throw new CalcException("Calc failed", CalcException.CalcErrorCodes.InvalidNumberText);
                throw new CalcException("Calc failed", CalcException.CalcErrorCodes.DivideByZero);

            }

            //throwing exc that contain particular data values
            catch  (CalcException c) when (c.Error == CalcException.CalcErrorCodes.DivideByZero)
            {
                Console.WriteLine("Divide by zero error");
            }
            catch (CalcException ce)
            {

                Console.WriteLine("ErrorL {0}", ce.Error);
            }

            Console.ReadLine();
        }


    }
}
