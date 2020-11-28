using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist
{
    class Song : IComparable
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public double Duration { get; set; }
        public Genre MusicGenre { get; set; }

        public Song(string title, string artist, double duration, Genre musicGenre)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            MusicGenre = musicGenre;
        }

        public Song(string title, string artist) : this(title, artist, 0, Genre.Other) { }

        public Song() : this("UNKNOWN", "UNKNOWN") { }

        public override string ToString()
        {
            return string.Format(Program.tblFormat, Artist, Title, Duration, MusicGenre);
        }

        public int CompareTo(object other)
        {
            //Creates a variable of type song that equals other
            //(Song)other casts other, which is originally type object, gets turned into type Song
            Song that = (Song)other;

            //Will sort by artist when sort method is called
            int returnValue = this.Artist.CompareTo(that.Artist);

            if (returnValue == 0)
            {
                //If artist is the same, sort by title
                returnValue = this.Title.CompareTo(that.Title);
            }

            return returnValue;
        }
    }

    public enum Genre { Rock, Pop, Dance, Other }
}