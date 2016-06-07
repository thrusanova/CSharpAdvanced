using System;

namespace TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            string[] listOfWords = Console.ReadLine().Split(new[] { ' ' ,','}, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            foreach (var item in listOfWords)
            {
                text = text.Replace(item, new string('*', item.Length));
            }
            Console.WriteLine(text);
        }
    }
}
