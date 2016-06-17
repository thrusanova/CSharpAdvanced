using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace JediDreams
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();
            var dict = new Dictionary<string, List<string>>();
            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                sb.Append(input);
            }
            // var staticPattern = @"static\s+[\w<>\[\],]+\s+(\w*[A-Z{1}\w*])";
            var staticPattern = @"static\s+[a-z]+\s+(\w+)";
            var invokeMethod = @"(\w*[A-Z]{1}\w*)\s*(?:\()";
            var methods = Regex.Matches(sb.ToString(), staticPattern);
            for (  int i = 0; i < methods.Count; i++)
            {
                string[] method = methods[i].Groups[0].Value.Split(' ');
                string meth = method[2];
                dict.Add(meth, new List<string>());
                sb.Replace(meth, "");
            }
            for (int i = 0; i < methods.Count; i++)
            {
                string[] method = methods[i].Groups[0].Value.Split(' ');
                string meth = method[2];
                var m = Regex.Matches(sb.ToString(), invokeMethod);
                foreach (Match item in m)
                {
                    dict[meth].Add(item.Groups[1].Value);
                    
                }
            }

           var result = dict.OrderByDescending(m => m.Value.Count).ThenBy(m => m.Key)
               .Select(
                m => new
                {
                   Name = m.Key,
                  MethodsCount = m.Value.Count,
                  Methods=string.Join(", ",m.Value.OrderBy(k=>k))
              });
           foreach (var item in result)
           {
              if (item.MethodsCount>0)
                {
                  Console.WriteLine($"{item.Name} -> {item.MethodsCount} -> {item.Methods}");
               }
               else
              {
                    Console.WriteLine($"{item.Name} -> None");
              }
            }
        }
    }
}
