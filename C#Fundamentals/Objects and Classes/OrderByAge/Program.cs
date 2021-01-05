using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            List<Person> listPers = new List<Person>();
            while (input[0] != "End")
            {
                Person currPerson = new Person();
                currPerson.Name = input[0];
                currPerson.ID = input[1];
                currPerson.Age = int.Parse(input[2]);
                listPers.Add(currPerson);




                input = Console.ReadLine().Split();
            }

            foreach (var item in listPers.OrderBy(a => a.Age))
            {
                Console.WriteLine($"{item.Name} with ID: {item.ID} is {item.Age} years old.");
            }



        }
    }
    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

    }
}
