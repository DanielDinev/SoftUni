using System;
using System.Collections.Generic;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {


            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();


            string input = Console.ReadLine();

            while (input!= "Revision")
            {
                string[] splitted = input.Split(", ");
                string shop = splitted[0];
                string product = splitted[1];
                double price = double.Parse(splitted[2]);

                if (shops.ContainsKey(shop))
                {
                    shops[shop].Add(product, price);
                }
                else
                {
                    shops.Add(shop, new Dictionary<string, double>());
                    shops[shop].Add(product, price);
                }
                input = Console.ReadLine();
            }

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }




            }







        }
    }
}
