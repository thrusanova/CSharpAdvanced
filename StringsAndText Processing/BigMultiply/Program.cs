using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMultiply
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine().TrimStart('0');
            byte second = byte.Parse(Console.ReadLine());
            if (first == "0" || second == 0 || first == "")
            {
                Console.WriteLine(0);
                return;
            }
            var reminder = 0;
            var str = "";
            var result = new StringBuilder();
            for (int i = first.Length - 1; i >= 0;  i--)
            {
                var augend = Convert.ToInt32(first.Substring(i, 1));
                
                var product = augend * second;
                
                    product += reminder;
                
                if (product > 9)
                {
                    reminder = product / 10;
                    product = product % 10;
                    
                }
                else
                {
                    reminder = 0;
                }
                result.Append(product);
            }
            if (reminder > 0)
            {
                result.Append(reminder);
                    }

            for (int i= result.Length-1; i >=0; i--)
            {
                str += result[i];
            }
            Console.WriteLine(str);
         

        }
    }
}
