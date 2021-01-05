using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split();
            List<Item> itemss = new List<Item>();
            List<Box> boxess = new List<Box>();
            while (input[0] != "end")
            {
                Item current = new Item(input[1], double.Parse(input[3]));
                itemss.Add(current);
                Box currBox = new Box(input[0], current, double.Parse(input[2]), double.Parse(input[2]) * double.Parse(input[3]));
                boxess.Add(currBox);





                input = Console.ReadLine().Split();
            }
            foreach (var item in boxess.OrderByDescending(n => n.PrizeBox))
            {
                Console.WriteLine(item.SerialNumber);
                Console.WriteLine($"-- {item.CurrentItem.Name} - ${item.CurrentItem.Prize:f2}: {item.Quantity}");
                Console.WriteLine($"-- ${item.PrizeBox:f2}");
            }



        }

    }

    class Item
    {
        private string name;
        private double prize;

        public Item(string name, double prize)
        {
            this.name = name;
            this.prize = prize;

        }

        public string Name
        {
            get { return name; }
            set { value = name; }
        }
      
        public double Prize 
        { 
            get { return prize; }
            set { value = prize; }
        }


    }
    class Box
    {
        private string serial;
        private Item currentItem;
        private double itemQuantity;
        private double prizePerBox;



        public Box(string serialNum, Item currItem, double itemQuantity, double prizeBox)
        {
            this.serial = serialNum;
            this.currentItem = currItem;
            this.itemQuantity = itemQuantity;
            this.prizePerBox = prizeBox;
        }

        public string SerialNumber
        {
            get { return serial; }
            set { value = serial; }
        }
        public Item CurrentItem
        {
            get { return currentItem; }
            set { value = currentItem; }
        }
        public double Quantity
        {
            get { return itemQuantity; }
            set { value = itemQuantity; }
        }
        public double PrizeBox
        {
            get { return prizePerBox; }
            set { value = prizePerBox; }
        }





    }
}
