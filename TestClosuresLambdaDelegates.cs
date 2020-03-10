using System;
using System.Collections.Generic;
using System.Text;

namespace Exam70_483
{
    class TestClosuresLambdaDelegates
    {
        class ScaleClosure
        {
            public int environment;
            public int Scale(int arg) => this.environment * arg;
        }

        static void Work(ScaleClosure scale)
        {
            int y = scale.Scale(5);
            Console.WriteLine(y);
        }

        public static void RunClosures()
        {
            var scale = new ScaleClosure() { environment = 2 };

            scale.environment = 5;
            Work(scale);
            Console.ReadLine();
        }


    }
}
