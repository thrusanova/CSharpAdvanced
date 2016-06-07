
namespace CountSymbols
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

   public class CountSymbols
    {
       public static void Main()
        {
            string input = Console.ReadLine();
            var dictionary = new Dictionary<char, int>();
            int value = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (!dictionary.ContainsKey(input[i]))
                {
                    value = 1;
                    dictionary.Add(input[i], value);
                    
                }
                else
                {
                    dictionary[input[i]]++;
                }
            }
            var list = dictionary.Keys.ToList();
            list.Sort();
            foreach (var pair in list)
            {
             
                Console.WriteLine("{0}: {1} time/s",pair,dictionary[pair]);
            }
        }
    }
}
