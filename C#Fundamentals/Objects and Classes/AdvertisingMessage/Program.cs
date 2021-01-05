using System;
using System.Collections.Generic;

namespace AdvertisingMessage
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> Phrases = new List<string> { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            List<string> Events = new List<string> { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            List<string> Authors = new List<string> { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            List<string> Cities = new List<string> { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};


            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int rndPhr = 0;
            int rndEv = 0;
            int rndAu = 0;
            int rndCit = 0;
              

            for (int i = 0; i < n; i++)
            {

                rndPhr = rnd.Next(0, Phrases.Count);
                rndEv = rnd.Next(0, Events.Count);
                rndAu = rnd.Next(0, Authors.Count);
                rndCit = rnd.Next(0, Cities.Count);

                Console.WriteLine($"{Phrases[rndPhr]} {Events[rndEv]} {Authors[rndAu]} – {Cities[rndCit]}.");



            }







        }
    }
}
