using System;
using System.Collections.Generic;
using System.Text;

namespace Exam70_483
{
    class _2_7_TestIndexOfandSubstring
    {
        /// <summary>
        /// IndexOf - gives start position (first occurence)
        /// </summary>
        public static void RunIndexOfandSubstring()
        {
            string s = "texthere^D123456_02";
            string result = s.Substring(s.IndexOf("^") + 1);//Remove all before
            result = result.Remove(result.IndexOf("_"));//Remove all after

            Console.WriteLine("Testing IndexOf and Remove: texthere^D123456_02:  " + result);





            string name = "something^M98547_007";
            //It will first remove whatever is after the "_" and whatever is before "^".
            name = name.Substring(0, name.LastIndexOf('_')).Substring(name.IndexOf("^") + 1);

            Console.WriteLine("Testing LastIndex of _ and IndexOf ^ from: something^M98547_007 -> " + name);


            string test = "testing*2111158588_007";
            test = test.Substring(0, test.LastIndexOf('*')); //will remove all after *




            #region Replace
            string toBeReplaced = "cupHalfFull";
            string replacedWord = toBeReplaced.Replace("cup", "glass");
            #endregion




            #region Split
            //split action returns array of strings
            string sentence = " The cat on    hot tin roof   ";
            string[] words = sentence.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            #endregion


            
            
            Console.WriteLine(test);
            Console.WriteLine(replacedWord);
            Console.ReadLine();
        }


    }
}
