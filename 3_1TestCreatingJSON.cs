using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;


namespace Exam70_483
{
    class _3_1TestCreatingJSON
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


        class ShortTrack
        {
            public string Artist { get; set; }
            public string Title { get; set; }

            // ToString that overrides the behavior in the base class
            public override string ToString()
            {
                return Artist + " " + Title;
            }

            public ShortTrack(string artist, string title)
            {
                Artist = artist;
                Title = title;
            }
        }









        public static void RunCreatingJSON()
        {
            MusicTrack track = new MusicTrack(artist: "Lewis Capaldi", title: "Before you go", length: 150);
            string json = JsonConvert.SerializeObject(track);
            Console.WriteLine("JSON: ");
            Console.WriteLine(json);



            MusicTrack trackRead = JsonConvert.DeserializeObject<MusicTrack>(json);
            Console.WriteLine("Read Back: ");
            Console.WriteLine(trackRead);

            List<MusicTrack> album = new List<MusicTrack>();

            string[] trackNames = new[] { "Someone you love", "Grace", "Hold me while you wait" };

            foreach  (string trackName in trackNames)
            {
                MusicTrack newTrack = new MusicTrack(artist: "Lewis Capaldi ", title: trackName, length: 150);
                album.Add(newTrack);
            }

            string jsonArray = JsonConvert.SerializeObject(album);
            Console.WriteLine("\nJSOn serialize: ");
            Console.WriteLine(jsonArray);

            List<MusicTrack> albumRead = JsonConvert.DeserializeObject<List<MusicTrack>>(jsonArray);

            Console.WriteLine("\nRead back deserialize ");
            foreach (MusicTrack readTrack in albumRead)
            {
                Console.WriteLine(readTrack);
            }
            Console.ReadLine();
        }


    }
}
