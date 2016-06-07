using System;
using System.Numerics;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ','\t' }, StringSplitOptions.RemoveEmptyEntries);


            decimal sum = 0m;
            for (int i = 0; i < input.Length; i++)
            {
               // decimal sum = 0m;
                char []first = input[i].Substring(0, 1).ToCharArray();
                char [] last = input[i].Substring(input[i].Length - 1, 1).ToCharArray();
                string str = input[i].Substring(1, input[i].Length - 2);
                decimal number = decimal.Parse(str);
              
                if (char.IsLower(first[0]))
                {
                    sum += number * (first[0] - 96);
                }
                else if(char.IsUpper(first[0]))
                {
                    sum += (decimal)(number / (first[0] - 64));
                }
                if (char.IsLower(last[0]))
                {
                    sum += (last[0] - 96);
                }
                else if (char.IsUpper(last[0]))
                {
                    sum -=(last[0] - 64);
                }
              //  totalsum += sum;

            }
            Console.WriteLine("{0:F2}",sum);
        }
    }
}
