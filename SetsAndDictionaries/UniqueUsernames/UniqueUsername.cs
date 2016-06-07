
namespace UniqueUsernames
{
    using System;
    using System.Collections.Generic;

   public class UniqueUsername
    {
      public  static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            var set = new HashSet<string>();
            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                set.Add(input);
            }
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
