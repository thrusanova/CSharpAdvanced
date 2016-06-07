using System;

namespace CountSubstringOccurrences
{
    class CountSubstr
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();
            string str = Console.ReadLine().ToLower();
            int count = 0;
            int index = 0;
           while (input.Contains(str))
            {
               int  currIndex = input.IndexOf(str, index);
                if (currIndex == -1)
                {
                    break;
                }
                index = currIndex + 1;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
