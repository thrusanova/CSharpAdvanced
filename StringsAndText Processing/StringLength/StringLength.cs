using System;
using System.Text;

namespace StringLength
{
    public  class StringLength
    {
      public  static void Main()
        {
            string input = Console.ReadLine();
            var sb = new StringBuilder();
            if (input.Length>=20)
            {
                for (int i = 0; i <= 20; i++)
                {
                    sb.Append(input[i]);
                }
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    sb.Append(input[i]);
                }
                for (int i = input.Length+1; i <= 20; i++)
                {
                    sb.Append("*");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
