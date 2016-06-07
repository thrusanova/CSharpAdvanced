using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PpisonPlant
{
  public  class PoisonPlant
    {
      public  static void Main()
        {
            int poison = int.Parse(Console.ReadLine());
            int[] plants = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var stack = new Stack<int>();
            int count = 0;
            for (int i = 0; i < plants.Length-1; i++)
            {
                if (plants[i+1]>=plants[i])
                {
                    stack.Push(plants[i]);
                    i++;
                }

            }
        }
    }
}
