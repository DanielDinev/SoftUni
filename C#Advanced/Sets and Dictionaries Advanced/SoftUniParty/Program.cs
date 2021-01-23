using System;
using System.Collections.Generic;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regGuests = new HashSet<string>();

            string input = Console.ReadLine();

            while (input != "END")
            {

                if (input == "PARTY")
                {
                    while (input != "END")
                    {
                        if (vipGuests.Contains(input))
                        {
                            vipGuests.Remove(input);
                        }
                        else if (regGuests.Contains(input))
                        {
                            regGuests.Remove(input);
                        }

                        input = Console.ReadLine();
                    }
                    break;

                }

                if (char.IsDigit(input[0]))
                {
                    vipGuests.Add(input);
                }
                else
                {
                    regGuests.Add(input);
                }

                input = Console.ReadLine();

            }

            int count = vipGuests.Count + regGuests.Count;
            Console.WriteLine(count);
            foreach (var guest in vipGuests)
            {
                Console.WriteLine(guest);
            }
            foreach (var guest in regGuests)
            {
                Console.WriteLine(guest);
            }




        }
    }
}
