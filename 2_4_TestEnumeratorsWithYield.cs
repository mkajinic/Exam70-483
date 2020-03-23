using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Exam70_483
{
    class _2_4_TestEnumeratorsWithYield
    {
        

        public class EnumeratorThing : IEnumerable<int>
        {


            public IEnumerator<int> GetEnumerator()
            {
                for (int i = 0; i < 10; i++)
                {
                    yield return i;
                }

            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            private int lm;
            public EnumeratorThing(int lm)
            {
                this.lm = lm;
            }



        }



     
        

        public IEnumerator<int> GetEnumerator()
        {
            yield return 8;
         //   yield return 2;
           // yield return 3;
        }



        public static void RunYield()
        {
            EnumeratorThing e = new EnumeratorThing(10);

            foreach (int i in e)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}


