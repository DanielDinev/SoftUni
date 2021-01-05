using System;
using System.Collections.Generic;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numSongs = int.Parse(Console.ReadLine());

            List < Songs > songs = new List<Songs>();

            for (int i = 0; i < numSongs; i++)
            {
                string[] data = Console.ReadLine().Split("_");

                string type = data[0];
                string name = data[1];
                string time = data[2];

                Songs song = new Songs();

                song.typeList = type;
                song.name = name;
                song.time = time;

                songs.Add(song);

            }

            string TypeList = Console.ReadLine();

            if (TypeList == "all")
            {
                foreach (Songs song in songs)
                {
                    Console.WriteLine(song.name);
                }
            }
            else
            {
                foreach (Songs song in songs)
                {
                    if (song.typeList == TypeList)
                    {
                        Console.WriteLine(song.name);
                    }
                }
            }

     

        }
    }
}
