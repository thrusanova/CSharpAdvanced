using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Hyperlinks
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string text = @"href=";
            Console.WriteLine(text);

            while (input != "END")
            {
                int firstIndex = input.IndexOf(text);//3
                //int lastIndex = input.First
                string st = "";
                for (int i = firstIndex+1; i < input.Length; i++)
                { 
                  //  if((char)input[i]=="\"")
                  //string st = input.Substring(firstIndex + text.Length,lastIndex-firstIndex);
                    Console.WriteLine(st);
                    input = Console.ReadLine();
                }
            }
        }
    }
}
 