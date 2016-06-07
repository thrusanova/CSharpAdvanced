using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melrah_Shake
{
    class Program
    {
     

        static void Main()
        {
            string input = Console.ReadLine();
            string text = Console.ReadLine();

            while (true)
            {
                int firstIndex = input.IndexOf(text);//3
                int lastIndex = input.LastIndexOf(text);//8
                if (firstIndex > -1 && lastIndex > -1 && text.Length > 0)
                {
                    StringBuilder sb = new StringBuilder(input);
                    sb.Remove(firstIndex, text.Length);//sta
                    sb.Remove(lastIndex - text.Length, text.Length);
                    input = sb.ToString();
                     Console.WriteLine("Shaked it.");
                        text = text.Remove(text.Length / 2, 1);   
                }
                else
                {
                    Console.WriteLine ("No shake.");
                    Console.WriteLine(input);
                    break;
                }
            }
        }
    }
}
