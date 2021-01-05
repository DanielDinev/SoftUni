using System;
using System.Collections.Generic;
using System.Linq;

namespace Students_ClassesAndObj_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> eachstudent = new List<Students>();
            bool sameName = false;

            string[] stud = Console.ReadLine().Split();

            while (stud[0] != "end")
            {
                
                string firstName = stud[0];
                string LastName = stud[1];
                string age = stud[2];
                string homeTown = stud[3];
                sameName = false;
                Students stud1 = new Students
                {
                    firstName = firstName,
                    lastName = LastName,
                    age = age,
                    homeTown = homeTown

                };

                if (eachstudent.Count > 0)
                {
                    foreach (Students item in eachstudent)
                    {

                        if (item.firstName == stud[0] && item.lastName == stud[1])
                        {
                            item.firstName = firstName;
                            item.lastName = LastName;
                            item.age = age;
                            item.homeTown = homeTown;
                            sameName = true;
                       }
                       
                    }
                }
                if (sameName == false)
                {
                    eachstudent.Add(stud1);
                }
                                    

                stud = Console.ReadLine().Split();
              

            }

            string inputCity = Console.ReadLine();

            foreach (Students item in eachstudent)
            {
                if (inputCity == item.homeTown)
                {
                    Console.WriteLine($"{item.firstName} { item.lastName} is { item.age } years old.");
                }
            }



        }
    }
    class Students
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string age { get; set; }
        public string homeTown { get; set; }




    }
}
