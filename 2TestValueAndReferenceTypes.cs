using System;
using System.Collections.Generic;
using System.Text;

namespace Exam70_483
{
    class _2TestValueAndReferenceTypes
    {
       
        public struct StructStore
        {
            public int Data { get; set; }
        }


        class ClassStore
        {
            public int Data { get; set; }
        }

        public static void RunTestValueAndReferenceTypes()
        {

            //Structure variables are managed by value
            //Changes to variable xStructs does not affect value of yStruct
            StructStore xs, ys;
            ys = new StructStore();
            ys.Data = 99;
            
            xs = ys;
            xs.Data = 100;
            Console.WriteLine("xStruct: {0}", xs.Data);
            Console.WriteLine("yStruct: {0}", ys.Data);




            //class variables are managed by reference
            //xClass and yClass referr to the same object
            ClassStore xc, yc;
            yc = new ClassStore();
            yc.Data = 99;
            Console.WriteLine("\nyClass first: {0}", yc.Data);

            xc = yc;
            Console.WriteLine("xClasst first: {0}", xc.Data);

            xc.Data = 100;
            Console.WriteLine("\nClass and yClass referr to the same object {0} as x and {1} as y", xc.Data, yc.Data);

            Console.WriteLine("\nxClass after : {0}", xc.Data);
            Console.WriteLine("yClass after: {0}", yc.Data);


        }

    }


    
}
