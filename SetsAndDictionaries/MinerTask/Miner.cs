using System;
using System.Collections.Generic;
using System.Numerics;

namespace MinerTask
{
   public class Miner
    {
       public static void Main()
        {
            string recourse = Console.ReadLine();
            if (recourse == "stop")
            {
                Console.WriteLine();
            }
            else
            {
                BigInteger amount = BigInteger.Parse(Console.ReadLine());
                var dict = new Dictionary<string, BigInteger>();
                while (recourse != "stop")
                {
                    if (!dict.ContainsKey(recourse))
                    {
                        dict.Add(recourse, amount);
                    }
                    else
                    {
                        dict[recourse] += amount;
                    }
                    recourse = Console.ReadLine();
                    if (recourse == "stop")
                    {
                        break;
                    }
                    amount = BigInteger.Parse(Console.ReadLine());
                }
                foreach (var pair in dict)
                {
                    Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
                }
            }         

        }
    }
}
