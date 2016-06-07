namespace StackFibonacci
{
    using System;
    using System.Collections.Generic;

   public class FibStack
    {
        public static long[] sequence;
      public static void Main()
        {
            //1, 1, 2, 3, 5, 8, 13, 21, 34… 
            int number = int.Parse(Console.ReadLine());
            Stack<long> stack = new Stack<long>();
            sequence = new long[number + 2];
            long first = 1;
            long second = 1;
            stack.Push(first);
            stack.Push(second);
            for (int i = 2; i < number; i++)
            {
                long num = stack.Pop();
                long peek = stack.Peek();
                stack.Push(num);
                stack.Push(num + peek);
            }
            Console.WriteLine(stack.Peek());
        }

    }

}

