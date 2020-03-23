using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;


namespace Exam70_483
{
    class _2_5_TestCreatingAttributeClass
    {

        //Attributes are metadata.
        // They are baked into the assembly at compile-time which has very serious implications of how you could set their properties.Only constant(known at compile time) values are accepte

        [AttributeUsage(AttributeTargets.Class)] //only allow Programmer attribute *ProgrammerAttribute* to be applied to class declarations
        class ProgrammerAttribute : Attribute
        {
            private string programmerValue;

            public ProgrammerAttribute (string programmer)
            {
                programmerValue = programmer;
            }

            public string Programmer
            {
                get
                {
                    return programmerValue;
                }
            }


        }

       
        [ProgrammerAttribute (programmer: "Fred")]
        class Person
        {
            public string Name { get; set; }
        }


        /*
        //this will use compilation error as we are only allowed to apply this  attribute to classes
        [ProgrammerAttribute (programmer: "fred")]
        public string Name { get; set; }
        */


       public static void RunAttributeClass()
        {

            System.Type type;

            Person human = new Person();
            type = human.GetType();
            Console.WriteLine("Person type: {0}", type.ToString());




            #region Calling a method on an object by using reflection

            //set the name of the person by using set_Name of Name property in Person class
            //its finding methodInfo 
          
            MethodInfo setMethod = type.GetMethod("set_Name");

            //calling invoke that is supplied with a referece to the Person that is the target of the method invocation and an array of oobject references -- whic will be used as arguments to that method call
            setMethod.Invoke(human, new object[] { "Fred" });

            Console.WriteLine("\nCalling a method on an object by using reflection");
            Console.WriteLine(human.Name);
            #endregion



            foreach (MemberInfo item in type.GetMembers())
            {
               
                Console.WriteLine("\nInfo about the Person class:");
                Console.WriteLine(item.ToString());
                
            }


            Attribute a = Attribute.GetCustomAttribute(typeof(Person), typeof(ProgrammerAttribute));

           
            ProgrammerAttribute p = (ProgrammerAttribute)a;

            Console.WriteLine("\nProgrammer: {0}", p.Programmer);



            Console.ReadKey();
        }


    }
}
