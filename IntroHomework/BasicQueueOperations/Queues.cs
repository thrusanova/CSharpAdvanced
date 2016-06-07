namespace BasicQueueOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Queues
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int queueCount = input[0];
            int popQueue = input[1];
            int elemToPop = input[2];
            int[] numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var queue = new Queue<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            for (int i = 0; i < popQueue; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(elemToPop))
            {
                Console.WriteLine("true");
            }
            else if (!queue.Contains(elemToPop) && queue.Count > 0)
            {
                Console.WriteLine(queue.Min());
            }
            else
            {
                Console.WriteLine(0);
            }


        }
    }
}
