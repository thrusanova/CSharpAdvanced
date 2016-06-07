namespace EmptyText
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class emptyStr
    {
     public  static void Main()
        {
            string text = "";
            int number = int.Parse(Console.ReadLine());
            var stack = new Stack<string>();
            stack.Push(text);
            for (int i = 0; i < number; i++)
            {
                string [] command = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                switch (command[0])
                {
                    case "1":text += command[1]; stack.Push(text); break;//abc
                    case "2":text = text.Substring(0,text.Length-int.Parse(command[1]));stack.Push(text); break;//
                    case "3": Console.WriteLine(text[int.Parse(command[1]) - 1]);break;//c
                    case "4": stack.Pop(); text=stack.Peek();   break;

                }
            }

        }
    }
}
