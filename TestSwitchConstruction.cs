using System;
using System.Collections.Generic;
using System.Text;

namespace Exam70_483
{
    class TestSwitchConstruction
    {
        public static void SwithcConstruction()
        {
            Console.Write("Enter Command: ");
            
            int command = int.Parse(Console.ReadLine());

            switch (command)
            {
                case 1:
                    Console.WriteLine("Command 1 chosen ");
                    break;

                case 2:
                    Console.WriteLine("Command 2 chosen ");
                    break;

                case 3:
                    Console.WriteLine("Command 3 chosen ");
                    break;

                default:
                    Console.WriteLine("Please enter a command in the range 1-3");
                    break;
            }
            

            Console.Write("Plase enter coomand");
            string commandName = (Console.ReadLine().ToLower());
            switch(commandName)
            {
                case "save":
                case "s":
                    Console.WriteLine("Save Command");
                    break;

                case "load":
                case "l":
                    Console.WriteLine("Load Command");
                    break;

                case "Exit":
                case "e":
                    Console.WriteLine("Save Command");
                    break;



                default:
                    Console.WriteLine("Please enter save, load or exit");
                    break;
            }



            Console.ReadLine();
        }


    }
}
