using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;

namespace Exam70_483
{
    class _2_2_TestIComparable
    {

       public class Employee : IComparable<Employee>
        {
            public string Name { get; set; }
            public int Salary { get; set; }


            public int CompareTo(Employee other)
            {
                if (this.Salary < other.Salary)
                {
                    return 1;
                }
                else if(this.Salary > other.Salary)
                {
                    return -1;    
                }
                else
                {
                    return 0;
                }
            }


            public override string ToString()
            {
                return $"{this.Name} {this.Salary}";
            }


        }


        class User : IComparable<User>
        {
            public string Name { get; set; }
            public string Occupation { get; set; }

            public int CompareTo(User other)
            {
                if (this.Occupation == other.Occupation)
                {
                    return this.Occupation.CompareTo(other.Occupation);
                }

                return this.Occupation.CompareTo(other.Occupation);
            }

            public override string ToString()
            {
                return $"{this.Name}, {this.Occupation.ToString()}";
            }
        }






        public static void RunIComparable()
        {
            var employees = new List<Employee>();

            employees.Add(new Employee() { Name = "Mark Twain", Salary = 1200 });
            employees.Add(new Employee() { Name = "Jane Austin", Salary = 1250 });
            employees.Add(new Employee() { Name = "Leo Tolstoy", Salary = 1550 });

            employees.Sort();

            employees.ForEach(employee => Console.WriteLine(employee));



            var users = new User[] {
                new User() { Name = "Robin", Occupation = "bookseller" },
                new User() { Name = "John", Occupation = "gardener" },
                new User() { Name = "John", Occupation = "writer" },
                new User() { Name = "Janet", Occupation = "teacher" },
                new User() { Name = "Andrew", Occupation = "driver" },
                new User() { Name = "Lucy", Occupation = "accountant" }

               };



            Array.Sort(users);

            foreach (var user in users)
            {
                Console.WriteLine(user);
            }

            Console.WriteLine("********************************");

            Array.Reverse(users);

            foreach (var user in users)
            {
                Console.WriteLine(user);
            }


        }

    }
}
