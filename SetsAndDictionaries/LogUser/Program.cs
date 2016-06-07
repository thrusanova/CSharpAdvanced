using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogUser
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            var result = new SortedDictionary<string, Dictionary<string, int>>();
            while (str!="end")
            {

                string[] input = str.Split(' ');
                string ip = input[0].Remove(0, 3);
                string user = input[2].Remove(0, 5);
                if (!result.ContainsKey(user))
                {
                    result.Add(user, new Dictionary<string, int>());
                    if (!result[user].ContainsKey(ip))
                    {
                        result[user].Add(ip, 0);
                        result[user][ip]++;
                    }
                    else
                    {
                        result[user][ip]++;
                    }

                }
                else
                {
                    if (!result[user].ContainsKey(ip))
                    {
                        result[user].Add(ip, 0);
                        result[user][ip]++;
                    }
                    else
                    {
                        result[user][ip]++;
                    }
                }

                str = Console.ReadLine();
            }
            var list = new List<string>();
            foreach (var pair in result)
            {
                Console.WriteLine(pair.Key+": ");
                foreach (var item in pair.Value)
                {
                    string st = string.Format("{0} => {1}", item.Key, item.Value);
                    list.Add(st);
                }
                string output = string.Join(", ", list);
                output += ".";
                Console.Write(output);
                Console.WriteLine();
                list.Clear();
            }

        }
    }
}
