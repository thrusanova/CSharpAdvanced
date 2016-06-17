using System;
using System.Text;

namespace ReplaceATag
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Replace('\n', '0');
            while (input!="end")
            {
                var sb = new StringBuilder();
                for (int i = 0; i < input.Length; i++)
                {
                  
                        sb.Append(input[i]);
                    
                }
                sb = sb.Replace("<a", "[URL");
                sb = sb.Replace("\">", "\"]");
                sb = sb.Replace("</a>", "[/URL]");
               
                Console.WriteLine(sb.ToString());
                input = Console.ReadLine();
            }
        }
    }
}
