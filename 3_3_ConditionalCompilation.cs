#define DIAGNOSTICS

using System;
using System.Collections.Generic;
using System.Text;

namespace Exam70_483
{
    class _3_3_ConditionalCompilation
    {

        public class MusicTrack
        {
            public static bool DebugMode = false;
            public string Artist { get; set; }
            public string Title { get; set; }
            public int Lenght { get; set; }

            //ToString that overrides behaviour of base class
            public override string ToString()
            {
                return Artist + " " + Title + " " + Lenght.ToString() + " seconds long";
            }

            public MusicTrack(string artist, string title, int lenght)
            {
                Artist = artist;
                Title = title;
                Lenght = lenght;

#if TERSE
            Console.WriteLine("Hello");
#elif NORMAL
            Console.WriteLine("Hello Meggie");
#elif CHATTY
            Console.WriteLine("Hello Meggie. What's the story");
#endif


#if DIAGNOSTICS && Debug
                Console.WriteLine("mUSIC TRACT CREATED: {0} ", this.ToString());
 #endif

            }


            






        }

        public static void RunConditionalCompilation()
        {
         //   MusicTrack.DebugMode = false;

            MusicTrack mt = new MusicTrack(artist: "Lewis Capaldi", title: "before you go", 180);
            Console.ReadLine();

        }

    }
}
