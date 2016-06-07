using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Palindromes
    {


       // var original = "ankYkna";
     //   var reversed = new string(original.Reverse().ToArray());
     //   var palindrom = original == reversed;

        static void Main(string[] args)
        {

            string [] input = Console.ReadLine().Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            var set = new SortedSet<string>();
            for (int i = 0; i < input.Length; i++)
            {
                var str = input[i];
                var reversed = new string(str.Reverse().ToArray());
                if (str == reversed)
                {
                    set.Add(str);
                }
            }
                 Console.Write("[");
                Console.Write(string.Join(", ",set));
            Console.WriteLine("]");
            
        }
    }
}
