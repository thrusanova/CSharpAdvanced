
namespace Problem_2.Sets_of_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Sets
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();
            var result = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int nums = int.Parse(Console.ReadLine());
                firstSet.Add(nums);
            }
            for (int i = 0; i < m; i++)
            {
                int nums = int.Parse(Console.ReadLine());
                secondSet.Add(nums);
            }
            result = firstSet.Intersect(secondSet).ToList();
            foreach (var item in result)
            {

                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

}
