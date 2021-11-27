using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace T02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {

            Regex regex = new Regex(@"([=\/])([A-Z][A-Za-z]{2,})\1");
            string input = Console.ReadLine();


            MatchCollection matches = regex.Matches(input);
            int index = 0;
            int travelPoints = 0;
            Console.Write("Destinations: ");
            foreach (Match match in matches)
            {
                index++;
                travelPoints += match.Groups[2].Length;
                Console.Write($"{match.Groups[2].Value}");
                if (index < matches.Count)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
            Console.Write($"Travel Points: {travelPoints}");





        }
    }
}
