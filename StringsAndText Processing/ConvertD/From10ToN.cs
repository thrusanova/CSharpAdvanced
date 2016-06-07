using System;
using System.Linq;
using System.Numerics;

namespace ConvertD
{
    class From10ToN
    {
        public static string Int64ToString(BigInteger value, long toBase)
        {
            string result = string.Empty;
            do
            {
                result = (int)(value % toBase) + result;
                value /= toBase;
            }
            while (value > 0);

            return result;
        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
          int baseN = int.Parse(input[0]);
           BigInteger number = BigInteger.Parse(input[1]);
           // var bigIntBytes = number.ToByteArray().Reverse().ToArray();
           // var res= Convert.ToBase64String(bigIntBytes);
            string num = Int64ToString(number, baseN);
            Console.WriteLine(num);

        }
    }
}
