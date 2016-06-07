using System;
using System.Collections.Generic;
using System.Linq;

namespace FixEmails
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            if (name == "stop")
            {
                Console.WriteLine();
            }
            else
            {
                string email = Console.ReadLine();
                var dict = new Dictionary<string, string>();
                while (name!="stop")
                {
                    if (!dict.ContainsKey(name))
                    {
                        dict.Add(name, email);
                    }
                    name = Console.ReadLine();
                    if (name == "stop")
                    {
                        break;
                    }
                    email = Console.ReadLine();
                }
                var itemsToRemove = dict.Where(pair => pair.Value.EndsWith("us") || pair.Value.EndsWith("uk")).ToArray();
                foreach (var pair in itemsToRemove)
                {
                        dict.Remove(pair.Key);
                   
                }
                foreach (var pair in dict)
                {
                    Console.WriteLine("{0} -> {1}",pair.Key,pair.Value);
                }
            }
            
        }
    }
}
