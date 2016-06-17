using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            var result= new SortedDictionary<string, SortedDictionary<string, int>>(); ;
            for (int i = 0; i < numbers; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string ip = input[0];
                string name = input[1];
                int duration = int.Parse(input[2]);
                int durr = 0;
                int currDur = 0;
                if (!result.ContainsKey(name))
                {
                 currDur = durr + duration;
                    result.Add(name,new SortedDictionary<string, int>());
                }
                if (!result[name].ContainsKey(ip))
                {
                    result[name][ip] = 0;
                }
                result[name][ip] += duration;

               
            }


            foreach (var entry in result)
            {
                String name = entry.Key;
                int sum = entry.Value.Values.Sum();
                Console.Write("{0}: {1} ",name,sum);
                Console.Write("[");
                Console.Write(string.Join(", " ,entry.Value.Keys));
                Console.WriteLine("]");
            }


        }
    }
}
