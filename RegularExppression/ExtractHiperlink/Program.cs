using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractHiperlink
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            while (!input.Equals("END"))
            {
                sb.Append(input);

                input = Console.ReadLine();
            }

            
            string pattern = @"<\s*a[^>]*href\s*=\s*(?:""([^""]+)""|\'([^\']+)\'|([^\s>]+))[^<]*>";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(sb.ToString());

            foreach (Match m in matches)
            {
                string group1 = m.Groups[1].Value;
                string group2 = m.Groups[2].Value;
                string group3 = m.Groups[3].Value;

                if (!string.IsNullOrEmpty(group1))
                {
                    Console.WriteLine(group1);
                }
                else if (!string.IsNullOrEmpty(group2))
                {
                    Console.WriteLine(group2);
                }
                else if (!string.IsNullOrEmpty(group3))
                {
                    Console.WriteLine(group3);
                }
            }
        }
    }
}