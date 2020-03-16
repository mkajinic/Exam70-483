﻿using System;
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





            ClassStore xc, yc;
            yc = new ClassStore();
            yc.Data = 99;
            xc = yc;
            xc.Data = 100;

            Console.WriteLine("xClasst: {0}", xc.Data);
            Console.WriteLine("yClass: {0}", yc.Data);


        }

    }


    
}
