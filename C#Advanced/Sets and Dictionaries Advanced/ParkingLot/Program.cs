using System;
using System.Collections.Generic;

namespace ParkingLot
{
    class Program
    {
        private static object hashSet;

        static void Main(string[] args)
        {

            HashSet<string> parking = new HashSet<string>();

            string[] input = Console.ReadLine().Split(", ");

            while (input[0] != "END")
            {
                string carPlate = input[1];
                if (input[0] == "IN")
                {
                    parking.Add(carPlate);
                }
                else if (input[0] == "OUT")
                {
                    parking.Remove(carPlate);
                }


                input = Console.ReadLine().Split(", ");

            }

            if (parking.Count > 0)
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }

            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            



        }
    }
}
