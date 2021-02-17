using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Song
    {
        //Fields

        //Properties
        public string Artist { get; set; }
        public string Title { get; set; }
        public int LengthInSeconds { get; set; }

        //Constructors
        public Song() { }

        public Song(string artist, string title, int lengthInSeconds)
        {
            Artist = artist;
            Title = title;
            LengthInSeconds = lengthInSeconds;
        }

        //Methods
        public override string ToString()
        {
            return string.Format("\"{0}\" by {1} ({2} seconds)",
                Title, Artist, LengthInSeconds);
        }//end ToString
    }//end class
}//end namespace
