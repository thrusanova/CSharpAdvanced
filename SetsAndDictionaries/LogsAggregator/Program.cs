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
            var result = new Dictionary<string, Dictionary<string, long>>();
            for (int i = 0; i < numbers; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string ip = input[0];
                string name = input[1];
                int duration = int.Parse(Console.ReadLine());
            }
        }
    }
}
