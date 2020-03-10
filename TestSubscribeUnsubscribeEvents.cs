using System;
using System.Collections.Generic;
using System.Text;

namespace Exam70_483
{
    class TestSubscribeUnsubscribeEvents
    {

        public class Alarm
        {
            public  Action OnAlarmRaised { get; set; }

            public void RaiseAlarm()
            {
                if (OnAlarmRaised != null)
                {
                    OnAlarmRaised();
                }
            }

            //Delegate for the alarm event
            //using delegate = no need to check weather delegate has value before calling it
            public event Action OnAlarmRaised2 = delegate { };
            public void RaiseAlarm2() //called to raise alarm  for delegate
            {
                OnAlarmRaised2();
            }

            //built in delegate types
            public event EventHandler OnAlarmRaised3 = delegate { };
            //does not provide any event arguments
            public void RaiseAlarm3()
            {
                OnAlarmRaised3(this, EventArgs.Empty); //first argument is reference to object rasing event
                //signature to be added to this delegate must reflect this (alarm listener)
            }
            

        }


        public static void RunSubscribeUnsubscribeEvent()
        {
             static void AlarmListener1() //method to run when alarm is raised
            {
                Console.WriteLine("Alarm listener 1 is called");
            }


            static void AlarmListener2() //method to run when alarm is raised
            {
                Console.WriteLine("Alarm listener 2 is called");
            }

            static void AlarmListener3(object sender, EventArgs e)
            {
                Console.WriteLine("alarm listener 3 is called");
            }


            static void ListenerMethods()
            {
                Alarm alarm = new Alarm();

                //subscribe
                //connect two listener methods
               // alarm.OnAlarmRaised += AlarmListener1;
               // alarm.OnAlarmRaised += AlarmListener2;


                //unsubscribe
              //  alarm.OnAlarmRaised -= AlarmListener1;
               


                alarm.RaiseAlarm();
                Console.WriteLine("alarm raised");

                Console.ReadLine();

            }

        }

        

    }
}
