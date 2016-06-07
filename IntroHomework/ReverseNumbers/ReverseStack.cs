using System;
using System.Collections.Generic;
using System.Linq;
class ReverseStack
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();
        var stack = new Stack<int>();
        for (int i = 0; i < input.Length; i++)
        {
            stack.Push(input[i]);
        }
        while (stack.Count != 0)
        {
            int number = stack.Pop();
            Console.Write(number + " ");
        }

        Console.WriteLine();
    }
}

