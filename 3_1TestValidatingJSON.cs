using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Exam70_483
{
    class _3_1TestValidatingJSON
    {


        class MusicTrack
        {
            public string Artist { get; set; }
            public string Title { get; set; }
            public int Length { get; set; }

            // ToString that overrides the behavior in the base class
            public override string ToString()
            {
                return Artist + " " + Title + " " + Length.ToString() + " seconds long";
            }

            public MusicTrack(string artist, string title, int length)
            {
                Artist = artist;
                Title = title;
                Length = length;
            }
        }



        public static void RunValidateJSON()
        {
            string invalidJson = "{\"Artist\":\"Rob Miles\",\"Title\":\"My Way\",\"Length\":150\"}";


            try
            {
                MusicTrack trackRead = JsonConvert.DeserializeObject<MusicTrack>(invalidJson);
                Console.Write("Read back: ");
                Console.WriteLine(trackRead);
            }
            catch (JsonReaderException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();

        }




    }
}
