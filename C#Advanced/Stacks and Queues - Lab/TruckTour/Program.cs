using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int truckFuel = 0;
            Queue<PetrolPumps> circle = new Queue<PetrolPumps>();
            int keepStartingIndex = 0;
           
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                PetrolPumps currentPump = new PetrolPumps();
                currentPump.PumpPetrol = input[0];
                currentPump.Distance = input[1];
                currentPump.Index = i;
                circle.Enqueue(currentPump);
            }
            Queue<PetrolPumps> secondQueue = new Queue<PetrolPumps>(circle);
            while (secondQueue.Count > 0)
            {
                
                truckFuel += secondQueue.Peek().PumpPetrol;
                int distance = secondQueue.Peek().Distance;
                if (secondQueue.Count == n)
                {
                    keepStartingIndex = secondQueue.Peek().Index;
                }
                if (truckFuel >= distance)
                {
                    truckFuel -= distance;
                   
                    secondQueue.Dequeue();
                }
                else
                {
                    PetrolPumps keep = circle.Peek();
                    circle.Dequeue();
                    circle.Enqueue(keep);
                    secondQueue = new Queue<PetrolPumps>(circle);
                    
                    truckFuel = 0;

                }

                
            }

            Console.WriteLine(keepStartingIndex);

        }
    }
    class PetrolPumps
    {
        public int Index { get; set; }
        public int PumpPetrol { get; set; }
        public int Distance { get; set; }
    }
}
