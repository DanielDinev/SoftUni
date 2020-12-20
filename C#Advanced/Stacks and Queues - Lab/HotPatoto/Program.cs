using System;
using System.Collections.Generic;
namespace HotPatoto
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Queue<string> players = new Queue<string>(input);
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            while (players.Count != 1)
            {

                
                    string potatoHolder = players.Dequeue();                  
                    count++;
                    if (count == n)
                    {
                        Console.WriteLine($"Removed {potatoHolder}");
                    count = 0;
                    }
                    else
                    {
                        players.Enqueue(potatoHolder);
                    }

            
                




            }
            Console.WriteLine($"Last is {players.Dequeue()}");

        }
    }
}
