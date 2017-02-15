using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("CD data:");
            List<CD> cd = new List<CD>();

            cd.Add(new CD { Artist = "Nightwish", Price = "19,95", SongList = "Songs" });

            Console.WriteLine(cd.ElementAt(0).ToString());

            List<Song> songs = new List<Song>();

            songs.Add(new Song { SongName = "Shudder Before the Beautiful", SongLength = "6:29" });
            songs.Add(new Song { SongName = "Weak Fantasy", SongLength = "5:23" });
            songs.Add(new Song { SongName = "Shudder Before the Beautiful", SongLength = "6:29" });
            songs.Add(new Song { SongName = "Elan", SongLength = "4:45" });
            songs.Add(new Song { SongName = "Yours Is an Empty Hope", SongLength = "5:34" });
            songs.Add(new Song { SongName = "Our Decades in the Sun", SongLength = "6:37" });
            songs.Add(new Song { SongName = "My Walden", SongLength = "4:38" });
            songs.Add(new Song { SongName = "Endless Forms Most Beautiful", SongLength = "5:07" });
            songs.Add(new Song { SongName = "Edema Ruh", SongLength = "5:15" });
            songs.Add(new Song { SongName = "Alpenglow", SongLength = "4:45" });
            songs.Add(new Song { SongName = "The Eyes of Sharbat Gula", SongLength = "6:03" });
            songs.Add(new Song { SongName = "The Greatest Show on Earth", SongLength = "24:00" });

            Console.WriteLine(songs.ElementAt(0).ToString());

            foreach (Song song in songs)
            {
                Console.WriteLine(song.ToString());
            }
        }
    }
}
