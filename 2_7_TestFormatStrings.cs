using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Exam70_483
{
    class _2_7_TestFormatStrings : IFormattable
    {

        string Artist { get; set; }
        string Title { get; set; }

        //ToString that implements formatting behavior
        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (string.IsNullOrWhiteSpace(format))//select default behavior if no format specified
            {
                format = "G";
            }

            switch (format)
            {
                case "A": return Artist;
                case "T": return Title;
                case "G": //default format
                case "F": return Artist + " " + Title;
                default: throw new FormatException("format specifier was invalid");
                   
            }
        }

        public override string ToString()//ToString that overrides behavior in the base class
        {
            return Artist + " " + Title;
        }


        public _2_7_TestFormatStrings(string artist, string title)
        {
            Artist = artist;
            Title = title;
        }





      


        public static void RunFormatString()
        {
            _2_7_TestFormatStrings song = new _2_7_TestFormatStrings(artist: "Miley Cyrus", title: " a song");

            Console.WriteLine("Track: {0:F}", song);
            Console.WriteLine("Artist: {0:A}", song);
            Console.WriteLine("title: {0:T}", song);


            Console.WriteLine("\n");



            // we can create a culture and explcitly pass it into a call of ToString
            double bankBalance = 452.65;
            CultureInfo usProvider = new CultureInfo("en-US");
            Console.WriteLine("US balance: {0}", bankBalance.ToString("C", usProvider));

            CultureInfo ukProvider = new CultureInfo("en-GB");
            Console.WriteLine("GB balance: {0}", bankBalance.ToString("C", ukProvider));

            CultureInfo jpnProvider = new CultureInfo("zh-CN");
            Console.WriteLine("JPN balance: {0}", bankBalance.ToString("C", jpnProvider));


            string name = "Magdalena";
            int age = 29;
            Console.WriteLine("\nYour name is {0} and you are {1, -16:D} years old      (with -16)" , name, age);
            Console.WriteLine("\nYour name is {0} and you are {1, 16:D} years old       (with 16)", name, age);

            #region String interpolation
            Console.WriteLine($"\nYour name is {name} and you are {age, -9:D} years old       (string interpolation)");
            Console.WriteLine(String.Format($"\nYour name is {name} and you are {age,-9:D} years old       (using string format)"));
            #endregion


        }


    }



   
}
