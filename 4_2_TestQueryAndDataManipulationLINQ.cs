using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exam70_483
{
    class _4_2_TestQueryAndDataManipulationLINQ
    {
        class Artist
        {
            public string Name { get; set; }
        }


        class MusicTrack
        {
            public Artist Artist { get; set; }
            public string Title { get; set; }
            public int Lenght { get; set; }
        }

        class TrackDetails
        {
            public string ArtistName;
            public string Title;
        }

        public static void RunLINQQuery()
        {
            //creating sample data
            string[] artistNames = new string[] { "Lewis Capaldi", "J Balvin", "Stroame", "Beyonce" };
            string[] titleNames = new string[] { "Bruises", "Rojo", "Formidable", "Listen" };


            List<Artist> artists = new List<Artist>();
            List<MusicTrack> musicTracks = new List<MusicTrack>();


            Random rand = new Random(1);

            foreach (string artistName in artistNames)
            {
                Artist newArtist = new Artist { Name = artistName };
                artists.Add(newArtist);
                foreach (string titleName in titleNames)
                {
                    MusicTrack newTrack = new MusicTrack
                    {
                        Artist = newArtist,
                        Title = titleName,
                        Lenght = rand.Next(20, 600)

                    };
                    musicTracks.Add(newTrack);
                }
            }

            //IEnumerable
           // Console.WriteLine("Using IEnumerable");
          // IEnumerable<MusicTrack> selectedTracks = from track in musicTracks where track.Artist.Name == "Lewis Capaldi" select track;


            //using select
            Console.WriteLine("\nUsing select");
            var selectedTracks = from track in musicTracks
                                 where track.Artist.Name == "Lewis Capaldi"
                                 select new TrackDetails
                                 {
                                     ArtistName = track.Artist.Name,
                                     Title = track.Title
                                 };

            //Annonymus type
            Console.WriteLine("\nAnnonymus type");
            var selectedTracks2 = from track in musicTracks
                                 where track.Artist.Name == "Rob Miles"
                                 select new
                                 {
                                     ArtistName = track.Artist.Name,
                                     track.Title
                                 };

            /*
            foreach (MusicTrack track in selectedTracks)
            {
                Console.WriteLine("Artist: {0} Title:{1} Lenght: {2}", track.Artist.Name, track.Title, track.Lenght);
            }
            */

            foreach (var item in selectedTracks)
            {
                Console.WriteLine("Artist:{0} Title:{1}", item.ArtistName, item.Title);
            }

            foreach (var item in selectedTracks2)
            {
                Console.WriteLine("Artist:{0} Title:{1}", item.ArtistName, item.Title);
            }

        }
    }
}
