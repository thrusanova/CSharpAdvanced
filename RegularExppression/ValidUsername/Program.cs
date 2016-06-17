using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ValidUsername
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string splitter = @"\W+";
            string[] input = Regex.Replace(line, splitter, " ").Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"^[a-zA-z][a-zA-Z0-9_]{2,24}$";
            Regex regex = new Regex(pattern);
           // MatchCollection match = regex.Matches(input.ToString());
            int index = 0;
            string currName = "";
            string lastName = "";
            string firstName = "";
            
            int sum = 0;
            var list = new List<string>();
            foreach (var item in input)
            {
                if (regex.IsMatch(item))
                {
                    list.Add(item);
                }
            }
            for (int i = 1; i < list.Count; i++)
            {
                int currSum = list[i - 1].Length + list[i].Length;
                if (currSum>sum)
                {
                    sum = currSum;
                    firstName = list[i - 1];
                    lastName = list[i];
                }
            }
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

        }
    }
}
