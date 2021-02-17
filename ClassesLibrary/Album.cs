using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Album
    {
        //Fields

        //Properties
        public Song[] Tracks { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        //Constructors
        public Album() { }

        public Album(Song[] tracks, string title, string genre)
        {
            Tracks = tracks;
            Title = title;
            Genre = genre;
        }

        //Methods
        public override string ToString()
        {
            string trackList = "";

            foreach (Song track in Tracks)
            {
                trackList += track + "\n";
            }

            return string.Format("Album Title: {0}\n" +
                "Genre: {1}\n" +
                "Track List:\n{3}",
                Title, Genre, trackList);
        }//end ToString
    }//end class
}//end namespace
