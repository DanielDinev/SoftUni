using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Vehicle_Catalog
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split();
            List<Cars> catCars = new List<Cars>();
            List<Truck> catTruck = new List<Truck>();

            while (input[0] != "End")
            {
                if (input[0] == "car" || input[0] == "Car")
                {
                    Cars current = new Cars();
                    current.Model = input[1];
                    current.Color = input[2];
                    current.HP = input[3];
                    catCars.Add(current);
                }
                else if (input[0] == "truck" || input[0] == "Truck")
                {
                    Truck currTruck = new Truck();
                    currTruck.Model = input[1];
                    currTruck.Color = input[2];
                    currTruck.HP = input[3];
                    catTruck.Add(currTruck);
                }



                input = Console.ReadLine().Split();
            }

            string input2 = Console.ReadLine();
            
            while (input2 != "Close the Catalogue")
            {
                bool flag = false;
                foreach (var item in catCars)
                {
                    if (input2 == item.Model)
                    {
                        Console.WriteLine($"Type: {item.type}");
                        Console.WriteLine($"Model: {item.Model}");
                        Console.WriteLine($"Color: {item.Color}");
                        Console.WriteLine($"Horsepower: {item.HP}");
                        flag = true;
                        break;

                    }
                }
                if (flag == true)
                {
                    input2 = Console.ReadLine();
                    continue;
                }
                foreach (var item in catTruck)
                {
                    if (input2 == item.Model)
                    {
                        Console.WriteLine($"Type: {item.type}");
                        Console.WriteLine($"Model: {item.Model}");
                        Console.WriteLine($"Color: {item.Color}");
                        Console.WriteLine($"Horsepower: {item.HP}");
                    }
                }




                input2 = Console.ReadLine();
            }

           

          

            if (catCars.Count > 0)
            {
                double averageCarHp = 0;
                foreach (var item in catCars)
                {
                    averageCarHp += double.Parse(item.HP);
                }
                averageCarHp = (averageCarHp * 1.00) / catCars.Count;
                Console.WriteLine($"Cars have average horsepower of: {averageCarHp:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }
            if (catTruck.Count > 0)
            {
                double averageTruckHp = 0;
                foreach (var item in catTruck)
                {
                    averageTruckHp += double.Parse(item.HP);
                }
                averageTruckHp = (averageTruckHp * 1.00) / catTruck.Count;
                Console.WriteLine($"Trucks have average horsepower of: {averageTruckHp:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
           
        }
      
       


    }
    class Cars
    {
        public string type = "Car" ;
        public string Model { get; set; }
        public string Color { get; set; }
        public string HP { get; set; }



    }
    class Truck
    {
        public string type = "Truck";
        public string Model { get; set; }
        public string Color { get; set; }
        public string HP { get; set; }
    }
}
