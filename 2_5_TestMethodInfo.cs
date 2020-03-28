using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Exam70_483
{
    class _2_5_TestMethodInfo
    {
        public class Calculator
        {
            public int Adding (int num1, int num2)
            {
                return num1 + num2;
            }
        }
        public static void RunMethodInfo()
        {

           // Console.WriteLine("Get the type information for the Calculator class");
            Type type = typeof(Calculator);

          Console.WriteLine("Get the method info for the Adding method  " );
            MethodInfo AddIntMethodInfo = type.GetMethod("Adding");

            Console.WriteLine("\nGet the IL instructions for the AddInt method");
            MethodBody AddIntMethodBody = AddIntMethodInfo.GetMethodBody();

            // Print the IL instructions. 
            foreach (byte b in AddIntMethodBody.GetILAsByteArray())
            {
                Console.Write("    {0:X}", b);
            }
            Console.WriteLine();

            Console.WriteLine("Create Calculator instance");
            Calculator calc = new Calculator();

            Console.WriteLine("Create parameter array for the method");
            object[] inputs = new object[] { 1, 5 };

            Console.WriteLine("Call Invoke on the method info");

            Console.WriteLine("Cast the result to an integer");
            int result = (int)AddIntMethodInfo.Invoke(calc, inputs);

            Console.WriteLine("\nResult of: {0}", result);

            Console.WriteLine("Call InvokeMember on the type"); //returns an object reference that must be cast to the actual type of method
            result = (int)type.InvokeMember("Adding",
                        BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public,
                        null,
                        calc,
                        inputs);
            Console.WriteLine(" Final  Result of: {0}", result);

            Console.ReadKey();


        }



    }
}
