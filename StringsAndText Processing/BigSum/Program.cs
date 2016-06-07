using System;

namespace BigSum
{
    class BigSum
    
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine().TrimStart('0');
            string second = Console.ReadLine().TrimStart('0');
            int maxLen = Math.Max(first.Length, second.Length);
            first = first.PadLeft(maxLen, '0');
            second = second.PadLeft(maxLen, '0');
            var carry = false;
            var result = String.Empty;

            for (int i = first.Length - 1; i >= 0; i--)
            {
                var augend = Convert.ToInt32(first.Substring(i, 1));
                var addend = Convert.ToInt32(second.Substring(i, 1));
                var sum = augend + addend;
                sum += (carry ? 1 : 0);
                carry = false;
                if (sum > 9)
                {
                    carry = true;
                    sum -= 10;
                }

                result = sum.ToString() + result;
            }

            if (carry)
            {
                result = "1" + result;
            }

            Console.WriteLine(result);
        }
    }
}
