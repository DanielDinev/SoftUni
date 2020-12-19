using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int quan = int.Parse(Console.ReadLine());
            Order(type, quan);



        }

        static void Order (string type, int quantity)
        {
            double price = 0;
            if (type == "coffee")
            {
                price = 1.50;
                Console.WriteLine($"{quantity * price:f2}");

            }
            else if (type == "water")
            {
                price = 1;
                Console.WriteLine($"{quantity * price:f2}");
            }
            else if (type == "coke")
            {
                price = 1.40;
                Console.WriteLine($"{quantity * price:f2}");
            }
            else if (type == "snacks")
            {
                price = 2;
                Console.WriteLine($"{quantity * price:f2}");
            }
        }
    }
}
