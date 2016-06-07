namespace StackOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StackOperations
    {
        static void Main()
        {
            int [] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int stackCount = input[0];
            int stackPopCount = input[1];
            int elemPop = input[2];
            int[] numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var stack = new Stack<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                stack.Push(numbers[i]);
            }
            for (int i = 0; i < stackPopCount; i++)
            {
                stack.Pop();
            }
           
                if (stack.Count==0)
                {
                    Console.WriteLine(0);
                }
                else if (stack.Contains(elemPop))
                {
                    Console.WriteLine("true");
                }  
                else
                {
                    Console.WriteLine(stack.Min());
                }
            
        }
    }
}
