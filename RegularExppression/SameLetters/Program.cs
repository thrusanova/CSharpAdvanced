using System;
using System.Text.RegularExpressions;

namespace SameLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
          
                string pattern = @"(.?)\1*";
                Regex regex = new Regex(pattern);
                MatchCollection match = regex.Matches(input);
                foreach (Match item in match)
                {
                    Console.Write(item.Groups[1].Value);
                }
            Console.WriteLine();
            
        }
    }
}
