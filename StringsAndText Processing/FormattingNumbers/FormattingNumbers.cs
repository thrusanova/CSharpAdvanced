using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int a = int.Parse(input[0]);
            double b = double.Parse(input[1]);
            double c = double.Parse(input[2]);
            string myHex = a.ToString("X");
            var result = Convert.ToString(a, 2).PadLeft(10, '0').Substring(0, 10);
            double after = Math.Round(b, 2, MidpointRounding.AwayFromZero);
            string s =String.Format("{0:0.00}", after).ToString().PadLeft(10);
            double before = Math.Round(c, 2, MidpointRounding.AwayFromZero);
            Console.Write("|{0}{1}",myHex,new string(' ' , 10-myHex.Length));
            Console.Write("|{0}",result);
            string p = String.Format("{0:0.000}", c).ToString();
            Console.Write("|{0}",s);
            Console.Write("|{0}{1}", p, new string(' ',10 - p.Length));
            Console.WriteLine("|");
        }
    }
}
