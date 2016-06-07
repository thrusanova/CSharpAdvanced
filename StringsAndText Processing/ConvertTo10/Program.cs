using System;
using System.Numerics;

namespace ConvertTo10
{
    class Program
    {

        private static BigInteger ToPower(int baseN, BigInteger power)
        {
            BigInteger result = 1;
            if (power != 0)
            {
                if (power == 1)
                {
                    result = baseN;
                }
                else
                {
                    result = baseN;

                    for (int i = 1; i < power; i++)
                    {
                        result *= baseN;
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int baseN = int.Parse(input[0]);
            string number = input[1];
            BigInteger power = number.Length - 1;
            BigInteger res = 0;
            for (int i = 0; i < number.Length; i++)
            {
                res += int.Parse(number[i].ToString()) * ToPower(baseN, power);
                power--;
            }
            Console.WriteLine(res);
        }
    }
}
        