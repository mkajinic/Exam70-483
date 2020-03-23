using System;
using System.Collections.Generic;
using System.Text;

namespace Exam70_483
{
    class _2_4_TestIDisposable
    {

        class CrucialConnection : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("Calling Dispose");
            }


            public void ThrowException()
            {
                throw new Exception("Bang");
            }
        }

        public static void RunIDisposable()
        {
            using (CrucialConnection conn = new CrucialConnection())
            {
                //doo something
            }

            Console.ReadLine();
        }


    }
}
