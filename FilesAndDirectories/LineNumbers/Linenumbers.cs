
namespace FilesAnd
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class OddLines
    {
        public static void Main(string[] args)
        {
            var output = File.ReadAllText("inputText.txt");
            string[] words = output.Split(new char[] { '.', '.', ' ', '?', '\n', '\r' },
                 StringSplitOptions.RemoveEmptyEntries);
            var dict = new Dictionary<string, int>();
            int count = 0;
            for (int i = 0; i < words.Count(); i++)
            {
                string st = words[i].ToLower();
                if (!dict.ContainsKey(st))
                {
                    dict.Add(st,count);
                }
             
            }
            var  newText = File.ReadAllText("text.txt");
            string[] newWords = newText.Split(new char[] {',', '.', '-', ' ', '?', '\n', '\r' },
                StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < newWords.Length; i++)
            {
                string st = newWords[i].ToLower();
                if (dict.ContainsKey(st))
                {
                    dict[st]++;
                }
            }
            var items = from pair in dict
                        orderby pair.Value descending
                        select pair;
            using (StreamWriter writer =
new StreamWriter("output.txt"))
            {
                foreach (var item in items)
            {
 
                    writer.WriteLine("{0} - {1}",item.Key,item.Value);    
                }
            }
          
        }
    }
}