using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml.Linq;

namespace Exam70_483
{
    class _4_3_TestModifyDataXMLwithLINQ
    {

        public static void RunXMLwithLINQ()
        {
            string XMLText =
                "<MusicTracks>" +
                    "<MusicTrack>" +
                        "<Artist>Rob Miles</Artist>  " +
                        "<Title>My Way</Title>  " +
                        "<Length>150</Length>" +
                    "</MusicTrack>" +

                    "<MusicTrack>" +
                        "<Artist>Immy Brown</Artist>  " +
                        "<Title>Her Way</Title>  " +
                        "<Length>200</Length>" +
                    "</MusicTrack>" +
                "</MusicTracks>";

            XDocument musicTrackDocument = XDocument.Parse(XMLText); //represents earlier text

            IEnumerable<XElement> selectedTracks = from track in musicTrackDocument.Descendants("MusicTrack")
                                                   where track.Element("Style") == null
                                                   select track;

            foreach (XElement item in selectedTracks)
            {
                item.Add(new XElement("Style", "Pop"));
            }

            Console.WriteLine(musicTrackDocument.ToString());
            Console.ReadLine();

        }
    }
}
