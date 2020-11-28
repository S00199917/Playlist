using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Playlist
{
    class Program
    {
        public static string tblFormat = "{0,-25}{1,-25}{2,-25}{3,-25}";
        static void Main(string[] args)
        {
            Song song1 = new Song("LINE WITHOUT A HOOK", "RICK MONTGOMERY", 4.10, Genre.Other);
            Song song2 = new Song("TICK TOCK", "CLEAN BANDIT", 2.58, Genre.Pop);
            Song song3 = new Song("HEY YA!", "OUTKAST", 3.55, Genre.Other);
            Song song4 = new Song("MR. SAXOBEAT", "ALEXANDRA STAN", 3.13, Genre.Pop);
            Song song5 = new Song("MS. JACKSON", "OUTKAST", 5.59, Genre.Other);

            List<Song> playlist = new List<Song>();

            playlist.Add(song1);
            playlist.Add(song2);
            playlist.Add(song3);
            playlist.Add(song4);
            playlist.Add(song5);

            DisplaySongs(playlist);

            playlist.Sort();

            DisplaySongs(playlist);

            Shuffle(playlist);
        }

        static void DisplaySongs(List<Song> playlist)
        {
            Console.WriteLine(tblFormat, "Artist", "Title", "Duration", "Genre");
            Console.WriteLine();

            foreach (Song song in playlist)
            {
                Console.WriteLine(song.ToString());
            }

            Console.WriteLine("\n\n");
        }

        static void Shuffle(List<Song> playlist)
        {
            int random;
            Random rnd = new Random();
            List<Song> shuffledPlaylist = new List<Song>();

            Console.WriteLine("Shuffling . . .");

            Thread.Sleep(1000);

            Console.WriteLine("Shuffling . . .");

            Thread.Sleep(1000);

            Console.WriteLine("Still shuffling . . .");

            Thread.Sleep(1000);

            Console.WriteLine("Done\n\n");
            Thread.Sleep(500);


            for (int i = 0; i < 5; i++)
            {
                random = rnd.Next(0, playlist.Count - 1);

                shuffledPlaylist.Add(playlist[random]);

                playlist.RemoveAt(random);
            }

            DisplaySongs(shuffledPlaylist);
        }
    }
}