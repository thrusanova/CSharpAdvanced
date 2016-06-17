using System;
using System.Text.RegularExpressions;

namespace RegularExppression
{
    class MatchFullName
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string pattern = @"\b([A-Z][a-z]+\s[A-Z][a-z]+)\b";
            Regex regex = new Regex(pattern);
            while (name!="end")
            {
                MatchCollection matches = regex.Matches(name);
                foreach (Match m in matches)
                {
                    Console.WriteLine(m.Groups[1].Value);
                }
                name = Console.ReadLine();

            }
        }
    }
}
