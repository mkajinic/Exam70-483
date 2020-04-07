using System;
using System.Collections.Generic;
using System.Text;

namespace Exam70_483
{
    class _2_TestSummary
    {

        public class Student
        {
          public string StudentName { get; set; }   
        }

        static void ChangeReferenceType(Student std2)
        {
            std2.StudentName = "Steve student 2";
        }

        class IntArrayWrapper
        {
            private int[] array = new int[100];
            public int this [int i]
            {
                get { return array[i]; }
                set { array[i] = value; }
            }
        }



        public static void RunSummary()
        {
            Student std1 = new Student();

            std1.StudentName = "Bill";

            ChangeReferenceType(std1);

            Console.WriteLine(std1.StudentName); //when we send the Student object std1 to the ChangeReferenceType() method, what is actually sent is the memory address of std1. Thus, when the ChangeReferenceType() method changes StudentName, it is actually changing StudentName of std1, because std1 and std2 are both pointing to the same address in memory. 




            IntArrayWrapper x = new IntArrayWrapper();
            x[1] = 99;
            Console.WriteLine("Indexed properties "+ x[1]);

            Console.ReadLine();
        }
        
    }
}
