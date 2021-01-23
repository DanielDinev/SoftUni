using System;
using System.Collections.Generic;

namespace Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> citiesCollections = new Dictionary<string, Dictionary<string, List<string>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (citiesCollections.ContainsKey(continent))
                {
                    if (citiesCollections[continent].ContainsKey(country))
                    {
                        citiesCollections[continent][country].Add(city);
                    }
                    else
                    {
                        citiesCollections[continent].Add(country, new List<string>());
                        citiesCollections[continent][country].Add(city);
                    }
                }
                else
                {
                    citiesCollections.Add(continent, new Dictionary<string, List<string>>());
                    citiesCollections[continent].Add(country, new List<string>());
                    citiesCollections[continent][country].Add(city);
                }




            }

            foreach (var continent in citiesCollections)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }






        }
    }
}
