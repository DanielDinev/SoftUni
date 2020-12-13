using System;
using System.Linq;
using System.Text;

namespace FinaxExam1
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            StringBuilder username = new StringBuilder(input);
            string[] command = Console.ReadLine().Split();

            while (command[0] != "Sign")
            {

                switch (command[0])
                {
                    case "Case":
                        if (command[1] == "lower")
                        {
                            string toLower = input.ToLower();
                            input = toLower;
                            username = new StringBuilder(input);
                            Console.WriteLine(username);
                        }
                        else if(command[1] == "upper")
                        {
                            string toUpper = input.ToUpper();
                            input = toUpper;
                            username = new StringBuilder(input);
                            Console.WriteLine(username);

                        }



                        break;
                    case "Reverse":

                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);
                        
                        if ((startIndex >= 0 && startIndex < username.Length) && (endIndex >= startIndex && endIndex < username.Length))
                        {
                            string subString = username.ToString().Substring(startIndex, (endIndex+1) - startIndex);
                            char[] rever = subString.Reverse().ToArray();
                            Console.WriteLine(string.Join("", rever));
                        }
                        else
                        {

                        }



                        break;
                    case "Cut":
                        string sub = command[1];
                        if (username.ToString().Contains(sub))
                        {
                            int indexOf = username.ToString().IndexOf(sub);
                            username.Remove(indexOf, sub.Length);
                            Console.WriteLine(username);
                        }
                        else
                        {
                            Console.WriteLine($"The word {username} doesn't contain {sub}.");
                        }


                        break;
                    case "Replace":
                        string currChar = command[1];
                        if (username.ToString().Contains(currChar))
                        {
                            username.Replace(currChar, "*");
                            Console.WriteLine(username);
                        }


                        break;
                    case "Check":

                        string givenChar = command[1];
                        if (username.ToString().Contains(givenChar))
                        {
                            Console.WriteLine("Valid");
                            return;
                        }
                        else
                        {
                            Console.WriteLine($"Your username must contain {givenChar}.");
                            return;
                        }


                        break;
                    case "Sign Up":
                        return;




                    default:
                        break;
                }









                command = Console.ReadLine().Split();
            }







        }
    }
}
