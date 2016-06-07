using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Phonebook
    {
        static void Main()
        {
            string input = Console.ReadLine();
           // Regex rgx = new Regex("[^a-zA-Z0-9]");
            var dict = new Dictionary<string, string>();
            while (input != "search")
            {
                // input = rgx.Replace(input, " ");
                string[] str = input.Split('-');
                string name = str[0];
                string number = str[1];
                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, number);
                }
                else if (dict.ContainsKey(name) && number!=dict[name])
                {
                    dict[name] = number;
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "stop") 
            {
              
                if (dict.ContainsKey(input))
                {
                    Console.WriteLine("{0} -> {1}", input,dict[input]);
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.",input);
                }
                input = Console.ReadLine();
            }

        //    Console.WriteLine("{0}->{1}",name,number);
        }
    }
}
