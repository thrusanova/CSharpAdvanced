using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace JediCodeX
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();
            var sb2 = new List<string>();
            var firstSb = new List<string>();
            var secondSb = new List<string>();
            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                sb.Append(input);
            }
            string firstPattern = Console.ReadLine();
            string secondtPattern = Console.ReadLine();
            int[] indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int firstLen = firstPattern.Length;
            int secondLen = secondtPattern.Length;

            string first = firstPattern + @"([a-zA-Z]+)";
            string second = secondtPattern + @"([a-zA-Z0-9]+)";

            var firstRegex = new Regex(first);
            var secondRegex = new Regex(second);

            MatchCollection match  = Regex.Matches(sb.ToString(),firstPattern + @"([a-zA-Z]{" + firstLen + @"})(?![a-zA-Z])");

            foreach (Match m in match)
            {
                string currentItem = m.Groups[1].Value;
                int len = currentItem.Length;
                if (len == firstLen)
                {
                    firstSb.Add(currentItem);
                }
            }

            MatchCollection matchTwo = Regex.Matches(sb.ToString(), secondtPattern + @"([a-zA-Z0-9]{" + secondLen + @"})(?![a-zA-Z0-9])");

            foreach (Match item in matchTwo)
            {
                string curr = item.Groups[1].Value;
                int length = curr.Length;
                if (length == secondLen)
                {
                    secondSb.Add(curr);
                }
            }
            for (int i = 0; i < indexes.Length; i++)
            {
                if (i<=secondSb.Count)
                {
                    int index = indexes[i];
                    sb2.Add(secondSb[index - 1]);
                }
            }
            for (int i = 0; i < firstSb.Count; i++)
            {
                if (i < sb2.Count)
                {
                    Console.WriteLine("{0} - {1}",firstSb[i],sb2[i]);
                }
            }
        }
    }
}
