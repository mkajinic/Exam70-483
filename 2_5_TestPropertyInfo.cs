using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Exam70_483
{
    class _2_5_TestPropertyInfo
    {

        public class Person
        {
            public string Name { get; set; }
            public string Age { get; }
        }


        public static void RunPropertyInfo()
        {
            Type typ = typeof(Person);

            foreach(PropertyInfo propInf in typ.GetProperties())
            {
                Console.WriteLine("Property name: {0} " , propInf.Name);

                if (propInf.CanRead)
                {
                    Console.WriteLine("\nCan read ");
                    Console.WriteLine("Set method: {0} ", propInf.GetMethod);
                }

                if (propInf.CanWrite)
                {
                    Console.WriteLine("\nCan write. ");
                    Console.WriteLine("Set method: {0} ", propInf.SetMethod);
                }



            }


            Console.ReadLine();
        }







    }
}
