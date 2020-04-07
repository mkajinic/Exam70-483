using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace Exam70_483
{
    class _3_2_TestSHA2Hashing
    {

        static byte[] calculateHash(string source)
        {
            // This will convert our input string into bytes and back
            ASCIIEncoding converter = new ASCIIEncoding();

            byte[] sourceBytes = converter.GetBytes(source);

            HashAlgorithm hasher = SHA256.Create();

            byte[] hash = hasher.ComputeHash(sourceBytes);

            return hash;
        }

        static void showHash(string source)
        {
            Console.Write("\nHash for {0} is: ", source);

            byte[] hash = calculateHash(source);

            foreach (byte b in hash)
            {
                Console.Write("{0:X} ", b);
            }

            Console.WriteLine();
        }


       public static void RunSHA2()
        {
            showHash("Hello world");
            showHash("world Hello");
            showHash("Hemmm world");
            showHash("Heloworld");

            Console.ReadKey();
        }

         
    }
}
