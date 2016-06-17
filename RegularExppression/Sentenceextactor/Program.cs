using System;
using System.Text.RegularExpressions;

namespace Sentenceextactor
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string input = Console.ReadLine();
            string pattern = string.Format(@"[^\.\!\?]*\b{0}\b[^\.\!\?]*[\.\!\?]", word);
            Regex regex = new Regex(pattern);
            MatchCollection match = regex.Matches(input);
            foreach (Match item in match)
            {
                if (item.Groups[0].Value.Contains(word))
                {
                    Console.WriteLine(item.Groups[0].Value);
                }
            }

        }
    }
}
