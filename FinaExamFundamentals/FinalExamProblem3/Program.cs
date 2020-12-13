using System;
using System.Text.RegularExpressions;

namespace FinalExam2
{
    class Program
    {
        static void Main(string[] args)
        {

            Regex catchingGroups = new Regex(@"([*@])(?<tag>[A-Z][a-z]{2,})\1: \[(?<g1>[A-z])\]\|\[(?<g2>[A-z])\]\|\[(?<g3>[A-z])\]\|\Z");


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (catchingGroups.IsMatch(input))
                {
                    Match firstMatch = catchingGroups.Match(input);
                    string tag = firstMatch.Groups["tag"].Value;
                    int g1 = char.Parse(firstMatch.Groups["g1"].Value);
                    int g2 = char.Parse(firstMatch.Groups["g2"].Value);
                    int g3 = char.Parse(firstMatch.Groups["g3"].Value);

                    Console.WriteLine($"{tag}: {g1} {g2} {g3}");



                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }




            }





        }
    }
}
