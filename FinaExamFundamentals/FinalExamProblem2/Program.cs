using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalExam3
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            Dictionary<string, Followers> listOfFollowers = new Dictionary<string, Followers>();
            string username = null;

            while (input != "Log out")
            {
                string[] command = input.Split(": ");

                switch (command[0])
                {
                    
                    case "New follower":
                         username = command[1];
                        if (listOfFollowers.ContainsKey(username))
                        {

                        }
                        else
                        {
                            Followers current = new Followers();
                            current.likes = 0;
                            current.comments = 0;
                            listOfFollowers.Add(username, current);

                        }


                        break;
                    case "Like":
                        username = command[1];
                        int counts = int.Parse(command[2]);
                        if (listOfFollowers.ContainsKey(username))
                        {
                            listOfFollowers[username].likes += counts;
                        }
                        else
                        {
                            Followers current = new Followers();
                            current.likes = counts;
                            current.comments = 0;
                            listOfFollowers.Add(username, current);
                        }


                        break;
                    case "Comment":
                        username = command[1];
                        
                        if (listOfFollowers.ContainsKey(username))
                        {
                            listOfFollowers[username].comments += 1;
                        }
                        else
                        {
                            Followers current = new Followers();
                            current.likes = 0;
                            current.comments = 1;
                            listOfFollowers.Add(username, current);
                        }



                        break;
                    case "Blocked":

                        username = command[1];
                        if (listOfFollowers.ContainsKey(username))
                        {
                            listOfFollowers.Remove(username);
                        }
                        else
                        {
                            Console.WriteLine($"{username} doesn't exist.");
                        }

                        break;




                    default:
                        break;
                }

              
              

                input = Console.ReadLine();
            }

            foreach (var item in listOfFollowers)
            {
                item.Value.total = item.Value.likes + item.Value.comments;
            }
            Console.WriteLine($"{listOfFollowers.Count} followers");
            foreach (var item in listOfFollowers.OrderByDescending(a => a.Value.total).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value.total}");



            }




        }









    }
    class Followers
    {
        public int likes { get; set; }
        public int comments { get; set; }
        public int total { get; set; }
        
    }
}
