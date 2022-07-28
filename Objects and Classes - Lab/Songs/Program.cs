using System;
using System.Collections.Generic;

namespace Objects__and_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int countSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 1; i <= countSongs; i++)
            {
                string songsArguments = Console.ReadLine();
                string[] songProperties = songsArguments.Split('_');
                Song currentSong = new Song(songProperties[0], songProperties[1], songProperties[2]);
                songs.Add(currentSong);
            }
            string type = Console.ReadLine();
            PrintMethod(type, songs);
        }

        static void PrintMethod(string type, List<Song> songs)
        {
            if (type=="all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList==type)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
    class Song
    {
        public Song(string typeList, string name, string time)
        {
            this.TypeList = typeList;
            this.Name = name;
            this.Time = time;
        }

        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
}
