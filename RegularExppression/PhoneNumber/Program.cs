using System;
using System.Text.RegularExpressions;

namespace PhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\+359(\s|\-)2{1}(\1)\d{3,3}(\1)\d{4,4}\b";
            Regex regex = new Regex(pattern);
            while (input != "end")
            {
                MatchCollection matches = regex.Matches(input);
                foreach (Match item in matches)
                {
                    Console.WriteLine(item.Groups[0].Value);
                    
                }
                input = Console.ReadLine();
            }
        }
    }
}
