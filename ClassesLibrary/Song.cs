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

        public Song(string title, string artist, int lengthInSeconds)
        {
            Artist = artist;
            Title = title;
            LengthInSeconds = lengthInSeconds;
        }

        //Additonal constructor to make adding songs easier.
        public Song(string title, string artist)
        {
            Title = title;
            Artist = artist;
        }

        //Methods
        public override string ToString()
        {
            return string.Format("{0} by {1}",
                Title, Artist);
        }//end ToString
    }//end class
}//end namespace
