using System;
using System.Collections.Generic;

namespace WardRobe
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
          

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string items = input[1];
                string [] itemSeparated = items.Split(",");

                if (wardrobe.ContainsKey(color))
                {
                    for (int x = 0; x < itemSeparated.Length; x++)
                    {
                        if (wardrobe[color].ContainsKey(itemSeparated[x]))
                        {
                            wardrobe[color][itemSeparated[x]]++;
                        }
                        else
                        {
                            wardrobe[color].Add(itemSeparated[x], 1);
                        }
                        
                    }
                }
                else
                {
                    wardrobe.Add(color, new Dictionary<string, int>());


                    for (int x = 0; x < itemSeparated.Length; x++)
                    {
                        if (wardrobe[color].ContainsKey(itemSeparated[x]))
                        {
                            wardrobe[color][itemSeparated[x]]++;
                        }
                        else
                        {
                            wardrobe[color].Add(itemSeparated[x], 1);
                        }
                    }
                }




            }
            string[] searchedItem = Console.ReadLine().Split();
            string searchedColor = searchedItem[0];
            string searchedCloth = searchedItem[1];



            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var cloth in color.Value)
                {
                    if (color.Key == searchedColor && cloth.Key == searchedCloth )
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");

                    }
                    

                }




            }



        }
    }
}
