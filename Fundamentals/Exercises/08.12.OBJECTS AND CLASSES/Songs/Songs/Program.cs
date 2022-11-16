using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Linq;
namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {

            int numSong = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < numSong; i++)
            {
                string[] data = Console.ReadLine().Split("_");

                var type = data[0];
                var name = data[1];
                var time = data[2];

                Song song = new Song();
                song.TypeList = type;
                song.Name = name;
                song.Time = time;
                songs.Add(song);
            }
            string typeList = Console.ReadLine();
            if (typeList == "all")
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
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }



            List<Song> filteredSongs = songs
                .Where(s => s.TypeList == typeList)
                .ToList();
        }


    }
}
