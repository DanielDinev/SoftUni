using System;
using System.Collections.Generic;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] initialSongs = Console.ReadLine().Split(", ");
            Queue<string> songs = new Queue<string>(initialSongs);

            while (songs.Count > 0)
            {
                string command = Console.ReadLine();

                if (command.StartsWith("Play"))
                {
                    songs.Dequeue();
                }
                else if (command.StartsWith("Add"))
                {
                    string song = command.Substring(4);
                    if (songs.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(song);
                    }


                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }

            }
            Console.WriteLine("No more songs!");

        }
    }
}
