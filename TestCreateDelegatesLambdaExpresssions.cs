using System;
using System.Collections.Generic;
using System.Text;

namespace Exam70_483
{
    class TestCreateDelegatesLambdaExpresssions
    {
        delegate int IntOperations(int a, int b);
        static int Add(int a, int b)
        {
            Console.WriteLine("Add called");
            return a + b;

        }

        static int Substract(int a, int b)
        {
            Console.WriteLine("Substract called");
            return a - b;

        }

        public static void RunCreateDelegates()
        {
            //explicitly create delegate
            IntOperations op = new IntOperations(Add);
            Console.WriteLine(op(9, 5));


            //delegate is created automaticaly from method
            op = Substract;
            Console.WriteLine(op(7, 6));
            Console.ReadLine();
        }


    }
}
