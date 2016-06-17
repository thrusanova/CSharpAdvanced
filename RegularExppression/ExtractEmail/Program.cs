using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExtractEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"([a-zA-Z0-9][a-zA-Z0-9\.\-_])*@([a-zA-Z]+[a-zA-Z\-\.]*[a-zA-Z]*\.[a-zA-Z]+)";
            var queue = new Queue<string>();
            Regex regex = new Regex(pattern);
            MatchCollection match = regex.Matches(input);
            foreach (Match m in match)
            {
                string email = m.Groups[1].Value;
                queue.Enqueue(email);
            }
            while (queue.Count()>0)
            {
                Console.WriteLine(queue.Dequeue());
            }

        }
    }
    }
