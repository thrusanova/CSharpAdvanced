using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWord
{

    class MagicWord
    {

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string first = input[0];
            string second = input[1];
            var dict = new Dictionary<char, char>();
            bool res = true;
            string maxLenStr = "";
            string minLenStr = "";

            if (first.Length >= second.Length)
            {
                maxLenStr = first;
                minLenStr = second;
            }
            else
            {
                maxLenStr = second;
                minLenStr = first;
            }
            for (int i = 0; i < maxLenStr.Length; i++)
            {
                if (i<minLenStr.Length)
                {
                    if (!dict.ContainsKey(maxLenStr[i]))
                    {
                        dict.Add(maxLenStr[i], minLenStr[i]);
                    }
                    else
                    {
                        if (dict[maxLenStr[i]] != minLenStr[i])
                        {
                            res = false;
                            break;
                        }
                    }
                }
                else
                {
                    if (!dict.ContainsKey(maxLenStr[i]))
                    {
                        res = false;
                    }
                }
  

            }
        
            Console.WriteLine(res.ToLowerString());
        }

    }
    public static class Extensions
    {
        public static string ToLowerString(this bool _bool)
        {
            return _bool.ToString().ToLower();
        }
    }
}
