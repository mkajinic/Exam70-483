using System;
using System.Collections.Generic;
using System.Text;

namespace Exam70_483
{
    class _2_1_IndexingOnStrings
    {

        //create an array to store the values
        private int[] array = new int[100];
        
        public int this[string name]
        {
            get
            {
                switch (name)
                {
                    case "zero": return array[0];
                    case "one": return array[1];

                    default: return -1;
                       
                }
            }

            set {
                switch(name) 
                {
                    case "zero": array[0] = value;
                        break;
                    case "one":  array[1] = value;

                        break;
                }
                    
            }
            
        }

        public static void RunIndexingOnStrings()
        {
            _2_1_IndexingOnStrings x = new _2_1_IndexingOnStrings();
            x["zero"] = 99;
            Console.WriteLine(x["zero"]);
        }


    }
}
