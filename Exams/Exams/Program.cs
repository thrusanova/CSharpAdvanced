using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exams
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            var regex = new Regex(@"\s*\|\s*");
            var data = new Dictionary<string, List<string>>();
            while (line!="report")
            {
                var input = regex.Split(line.Trim());
                var name = Regex.Replace(input[0].Trim(), @"\s+", " ");
                var country = Regex.Replace(input[1].Trim(), @"\s+", " ");
                if (!data.ContainsKey(country))
                {
                    data.Add(country, new List<string>());
                }
                data[country].Add(name);
                line = Console.ReadLine();

            }

            var sortedData = data.OrderByDescending(x => x.Value.Count);
            foreach (var item in sortedData)
            {
                Console.WriteLine($"{item.Key} ({item.Value.Distinct().Count()} participants): {item.Value.Count} wins");
            }
        }
    }
}
