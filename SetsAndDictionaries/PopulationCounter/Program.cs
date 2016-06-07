using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            var result = new Dictionary<string, Dictionary<string, long>>();
            while (str!="report")
            {
                string[] input = str.Split('|');
                string country = input[1];
                string city = input[0];
                long population = long.Parse(input[2]);
                long pop = 0;
                if (!result.ContainsKey(country))
                {
                    result.Add(country, new Dictionary<string, long>());
                    if (!result[country].ContainsKey(city))
                    {
                        pop += population;
                        result[country].Add(city, pop);
                    }
                    else
                    {
                        result[country].Add(city, pop+population);
                    }
                }
                else
                {
                    if (!result[country].ContainsKey(city))
                    {
                        pop += population;
                        result[country].Add(city, pop);
                    }
                    else
                    {
                        result[country].Add(city, pop + population);
                    }
                }

                str = Console.ReadLine();       
            }
            var sorted = result.OrderByDescending(p => p.Value.Sum(x=>x.Value));
            foreach (var pair in sorted)
            {
                Console.WriteLine("{0} (total population: {1})",pair.Key,pair.Value.Values.Sum());
                foreach (var item in pair.Value.OrderBy(x=>-x.Value))
                {
                    Console.WriteLine("=>{0}: {1}", item.Key,item.Value);
                }
            }

            }
        }
    }

