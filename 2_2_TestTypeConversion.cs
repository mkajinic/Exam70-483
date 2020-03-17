using System;
using System.Collections.Generic;
using System.Text;

namespace Exam70_483
{
    class _2_2_TestTypeConversion
    {

        class Miles
        {
            public double Distance { get; }

            public static implicit operator Kilometers(Miles t)
            {
                Console.WriteLine("Implicit conversion from miles to kilomenters");
                return new Kilometers(t.Distance - 1.6);

            }

            public static explicit operator int(Miles t)
            {
                Console.WriteLine("Explicit conversion from miles to int ");
                return (int)(t.Distance + 0.5);
            }


            public Miles(double miles)
            {
                Distance = miles;
            }

        }
        

        class Kilometers
        {

            public double Distance { get; }


            public Kilometers (double kilometers)
            {
                Distance = kilometers;
            }


        }


        public static void RunTypeConversion()
        {
            Miles m = new Miles(156);

            Kilometers k = m; // implicitly convert miles to km

            Console.WriteLine("Kilometers: {0}", k.Distance);

            int intMiles = (int)m; // explicitly convert miles to int

            Console.WriteLine("Int miles: {0}", intMiles) ;
            Console.ReadLine();



        }



    }
}
