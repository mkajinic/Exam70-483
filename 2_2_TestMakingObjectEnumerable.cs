using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Exam70_483
{
    class _2_2_TestMakingObjectEnumerable
    {
        class EnumeratorThing : IEnumerator<int>, IEnumerable
        {
            int count;
            int limit;


            public int Current
            {
                get
                {
                    return count;
                }
            }

            object IEnumerator.Current
            {
                get { return count; }
            }

            public void Dispose()
            {

            }


            public bool MoveNext()
            {
                if (++count == limit)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }


            public void Reset()
            {
                count= 0;
            }


            public IEnumerator GetEnumerator()
            {
                return this;
            }


            public EnumeratorThing(int limit)
            {
                count = 0;
                this.limit = limit;
            }

        }


        public static void RunObjectEnumerable()
        {
            EnumeratorThing e = new EnumeratorThing(10);
            foreach (int item in e)
            {
                Console.WriteLine(item);
            }
        }
        

            


    }
}
