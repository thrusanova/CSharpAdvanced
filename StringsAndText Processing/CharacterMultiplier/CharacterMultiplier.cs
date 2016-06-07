using System;
using System.Numerics;

namespace CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            string [] input = Console.ReadLine().Split(' ');
            string firstStr = input[0];
            string secondStr = input[1];
            BigInteger result = reminderStr(firstStr, secondStr);
            Console.WriteLine(result);

        }
       

        public static BigInteger reminderStr(string first, string second)
        {
            BigInteger reminderSum = 0;
            string maxStr = "";
            int maxLen = Math.Max(first.Length, second.Length);
            int minLen = Math.Min(first.Length, second.Length);
            if (first.Length >= second.Length)
            {
                maxStr = first;
            }
            else
            {
                maxStr = second;

            }
            for (int i = 0; i < maxStr.Length; i++)
            {
                if (i < minLen)
                {
                    reminderSum += first[i] * second[i];
                }
                else
                {
                    reminderSum += maxStr[i];
                }
            }
            return reminderSum;
        }
    }
    }

