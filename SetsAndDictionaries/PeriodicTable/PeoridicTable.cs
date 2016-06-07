
namespace PeriodicTable
{ 
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PeoridicTable
    {
       public static void Main()
        {
            int nums = int.Parse(Console.ReadLine());
            var set = new SortedSet<string>();
            for (int i = 0; i < nums; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < input.Length; j++)
                {
                    set.Add(input[j]);
                }
                
            }
            foreach (var item in set)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
    }
}
