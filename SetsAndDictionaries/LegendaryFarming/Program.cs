using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
           var junk = new SortedDictionary<string,int>();
            var result = new Dictionary<string, int>();
            result.Add("fragments", 0);
            result.Add("motes", 0);
            result.Add("shards", 0);
            string getMaterial = "";
            while (true)
            {
                string input = Console.ReadLine();
                string[] str = input.Split(' ');
                //3 Motes 5 stones 5 Shards
                for (int i = 0; i < str.Length - 1; i += 2)
                {
                    int value = int.Parse(str[i]);
                    string material = str[i + 1].ToLower();
                    int amount = 0;
                    if (result.ContainsKey(material))
                    {
                        amount = result[material];

                        result[material] = amount + value;
                        if (result[material] >= 250)
                        {
                            result[material] = result[material] - 250; ;
                            getMaterial = material;
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk.Add(material, 0);
                        }
                        junk[material] += value;
                       // junk.Add(material, junk[material] + value);

                    }
                }

                if (getMaterial.Length > 0)
                {
                    break;
                }

            }
            var items = from pair in result
                        orderby pair.Value descending
                        select pair;
            Console.WriteLine(getLegendary(getMaterial));
            foreach (var pair in items)
            {
                Console.WriteLine("{0}: {1}",pair.Key,pair.Value);
            }
            foreach (var item in junk)
            {
                Console.WriteLine("{0}: {1}",item.Key,item.Value);
            }
        }

        public static string getLegendary(string material)
        {
            if (material=="fragments")
            {
                return "Valanyr obtained!";
            }
            else if (material=="motes")
            {
                return "Dragonwrath obtained!";
            }
            return "Shadowmourne obtained!";
        }

    }


}