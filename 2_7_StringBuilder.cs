using System;
using System.Collections.Generic;
using System.Text;

namespace Exam70_483
{
    /// <summary>
    /// StringBuilder is mutable.
    ///  performs faster than string when appending multiple string values.
    ///  Use StringBuilder when you need to append more than three or four strings.
    /// </summary>

    class _2_7_StringBuilder
    {
        public static void RunStringBuilder()
        {
            StringBuilder sb = new StringBuilder("Hello " , 50);

            sb.Append("Testing");
            sb.AppendLine(" ....aaaand Dance!");
            sb.Append("This should be in new line");

            Console.WriteLine(sb);


            //Use AppendFormat method to format input string into specified format and then append it.
            StringBuilder amtMsg = new StringBuilder("Total amount to pay is: ");
            amtMsg.AppendFormat("{0:C}", 25);
            Console.WriteLine(amtMsg);


            StringBuilder ind = new StringBuilder("Hello World!!", 50);
            ind.Insert(5, " C#");

            Console.WriteLine(ind);


            //The Remove() method removes the string at starting at specified index(2) with specified length (5).
            StringBuilder del = new StringBuilder("Hello World!!", 50);
            del.Remove(2, 5);
            Console.WriteLine(del);

            Console.ReadLine();
        }


    }
}
