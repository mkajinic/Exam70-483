using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Exam70_483
{
    class _2_5_TestAssemblyObject
    {

        public static void RunAssembly()
        {

            Assembly assembly = Assembly.GetExecutingAssembly();


            Console.WriteLine("Full name: {0}", assembly.FullName);
            AssemblyName name = assembly.GetName();

            Console.WriteLine("Major version: {0} ", name.Version.Major);
            Console.WriteLine("Minor version: {0} ", name.Version.Minor);

            Console.WriteLine("Un global assembly cache: {0} ", assembly.GlobalAssemblyCache);

            foreach (Module assemblyModule in assembly.Modules)
            {
                Console.WriteLine(" Module: {0} ", assemblyModule.Name);

                foreach (Type moduleType in assemblyModule.GetTypes())
                {
                    Console.WriteLine("   Type: {0} ", moduleType.Name);

                    foreach (MemberInfo member in moduleType.GetMembers())
                    {
                        Console.WriteLine("     Member: {0} ", member.Name);


                    }



                }
            }


            Console.ReadLine();



        }



    }
}
