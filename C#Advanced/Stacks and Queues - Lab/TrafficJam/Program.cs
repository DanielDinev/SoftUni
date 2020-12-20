using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {

            int canPass = int.Parse(Console.ReadLine());
            Queue<string> carsInJam = new Queue<string>();

            string command = Console.ReadLine();
            int count = 0;
            while (command != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < canPass; i++)
                    {
                        if (carsInJam.Count > 0)
                        {
                            Console.WriteLine($"{carsInJam.Dequeue()} passed!");
                            count++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    carsInJam.Enqueue(command);
                }








                command = Console.ReadLine();
            }

            Console.WriteLine($"{count} cars passed the crossroads.");


        }
    }
}
