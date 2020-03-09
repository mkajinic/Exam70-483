using System;
using System.Collections.Generic;
using System.Text;

namespace Exam70_483
{
    class TestIterateWithFor
    {
        public static void RunIterateWithFor()
        {
            string[] names = { "Millie", "Mary", "Jason", "Bob"};

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
                
            }

            Console.WriteLine("---------");

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
                if (names[i] == "Jason")
                {
                    break;
                }
            }

            Console.WriteLine("---------");

            foreach (string name in names)
            {
                
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }


    }
}
