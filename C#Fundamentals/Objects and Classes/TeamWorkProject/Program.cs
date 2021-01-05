using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;

namespace TeamWorkProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Teams> listTeams = new List<Teams>();
            bool flag = false;
            int check = 0;

            for (int i = 0; i < n; i++)
            {
                flag = false;
                string[] input = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);
                for (int x = 0; x < listTeams.Count; x++)
                {
                    if (listTeams[x].TeamName == input[1])
                    {
                        Console.WriteLine($"Team {input[1]} was already created!");
                        flag = true;
                        break;
                    }
                    else if (listTeams[x].CreatorName == input[0])
                    {
                        Console.WriteLine($"{input[0]} cannot create another team!");
                        flag = true;
                    }
                }
                if (flag == true)
                {
                    continue;
                }
                Teams currTeam = new Teams();
                currTeam.CreatorName = input[0];
                currTeam.TeamName = input[1];
                currTeam.Members = new List<string>(5);
                listTeams.Add(currTeam);
                Console.WriteLine($"Team {currTeam.TeamName} has been created by {currTeam.CreatorName}!");

            }

            string[] userRegister = Console.ReadLine().Split("->", StringSplitOptions.RemoveEmptyEntries);
            bool flag1 = false;

            while (userRegister[0] != "end of assignment")
            {
                flag1 = false;
                bool teamExist = false;
                for (int i = 0; i < listTeams.Count; i++)
                {


                    if (listTeams[i].TeamName == userRegister[1])
                    {
                        check = i;   
                        teamExist = true;
                    }
                }
                if (teamExist == false)
                {
                    Console.WriteLine($"Team {userRegister[1]} does not exist!");
                    userRegister = Console.ReadLine().Split("->", StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }






                for (int x = 0; x < listTeams.Count; x++)
                {
                    if (listTeams[x].Members.Contains(userRegister[0]) || listTeams[x].CreatorName == userRegister[0])
                    {
                        Console.WriteLine($"Member {userRegister[0]} cannot join team {userRegister[1]}!");
                        flag1 = true;
                        userRegister = Console.ReadLine().Split("->", StringSplitOptions.RemoveEmptyEntries);
                        break;
                    }
                }
                if (flag1 == true)
                {
                    break;
                }
                if (flag1 == false && teamExist == true)
                {
                    listTeams[check].Members.Add(userRegister[0]);
                }
             







                userRegister = Console.ReadLine().Split("->", StringSplitOptions.RemoveEmptyEntries);
            }
            
            foreach (Teams item in listTeams.OrderByDescending(a => a.Members.Count).ThenBy(a => a.TeamName))
            {
                if (item.Members.Count > 0)
                {
                    Console.WriteLine($"{item.TeamName}");
                    Console.WriteLine($"- {item.CreatorName}");
                    foreach (var member in item.Members.OrderBy(a => a))
                    {
                        Console.WriteLine($"-- {member}");
                    }
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (Teams item in listTeams.OrderBy(a => a.TeamName))
            {
                if (item.Members.Count == 0)
                {
                    Console.WriteLine(item.TeamName);
                    
                }
            }




        }






    }
    public class Teams
    {
        public string CreatorName { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }
        



    }

}
