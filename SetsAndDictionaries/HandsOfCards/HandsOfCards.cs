using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOfCards
{
    class HandsOfCards
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
               var dict = new Dictionary<string, int>();
            while (input!="JOKER")
            {
                string[] str = input.Split(':');
                string name = str[0];
                string[] cards = str[1].Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int result = 0;
                var set = new HashSet<string>();
                for (int i = 0; i < cards.Length; i++)
                {
                    set.Add(cards[i]);
                }
                string[] stringArray = new string[set.Count];
                set.CopyTo(stringArray);
                set.Clear();
                for (int i = 0; i < stringArray.Length; i++)
                {
                    string s = cards[i];
                    char ch = s[s.Length - 1];
                    s = s.Substring(0, s.Length - 1);
                    int type = 0;
                    int card = 0;

                    switch (s)
                    {
                        case "2": card = 2; break;
                        case "3": card = 3; break;
                        case "4": card = 4; break;
                        case "5": card = 5; break;
                        case "6": card = 6; break;
                        case "7": card = 7; break;
                        case "8": card = 8; break;
                        case "9": card = 9; break;
                        case "10": card = 10; break;
                        case "J": card = 11; break;
                        case "Q": card = 12; break;
                        case "K": card = 13; break;
                        case "A": card = 14; break;
                    }
                    switch (ch)
                    {
                        case 'S': type = 4; break;
                        case 'H': type = 3; break;
                        case 'D': type = 2; break;
                        case 'C': type = 1; break;
                    }
                    result += type * card;
                }
                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, result);
                }
                else
                {
                    dict[name] += result;
                    result = 0;
                }
                input = Console.ReadLine();

            }           
            foreach (var pair in dict)
            {
                Console.WriteLine("{0}: {1}",pair.Key,pair.Value);
            }
        }
    }
}
