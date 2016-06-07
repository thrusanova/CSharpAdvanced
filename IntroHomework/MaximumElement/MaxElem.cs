namespace MaximumElement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MaxElem
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            int max = 0;
            for (int i = 0; i < numbers; i++)
            {
                string input = Console.ReadLine();
              if (input.Length>1)
                {
                    string[] command = input.Split(' ');
                    int num = int.Parse(command[1]);
                    if (num > max)
                    {
                        max = num;
                    }
                    stack.Push(num);
                }
                else if (input=="2")
                {
                    stack.Pop();
                    if (stack.Count > 0)
                    {
                        max = stack.Max();
                    }
                    else
                    {
                        max = 0;
                    }
                }
              else
                {
                    Console.WriteLine(max);
                }

            }
        }
    }
}

