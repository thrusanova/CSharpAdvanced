using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> collection = Console.ReadLine()
          .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
          .ToList();
            string command = Console.ReadLine();
            while (command != "end")
            {
                ExecuteCommand(command.Split(), collection);
                command = Console.ReadLine();
            }
            Console.WriteLine("[{0}]",string.Join(", ",collection));
        }

        private static void ExecuteCommand(string[] args, List<string> collection)
        {
            string operation = args[0];
            switch (operation)
            {
                case "reverse":ReverseCommand(args, collection);break;
                case "sort":SortCommand(args, collection);break;
                case "rollLeft":RollLeftCommand(args, collection);break;
                case "rollRight":RollRightCommand(args, collection);break;
            }
        }

        private static void RollRightCommand(string[] args, List<string> collection)
        {
            var numberofRolls = int.Parse(args[1]) % collection.Count;
            var elems = collection.Skip(collection.Count - numberofRolls)
                .Take(numberofRolls).ToArray();
            collection.InsertRange(0, elems);
            collection.RemoveRange(collection.Count - numberofRolls, numberofRolls);
        }

        private static void RollLeftCommand(string[] args, List<string> collection)
        {
            var numberOfRolls = int.Parse(args[1]) % collection.Count;
            var elements = collection.Take(numberOfRolls).ToArray();
            collection.AddRange(elements);
            collection.RemoveRange(0, numberOfRolls);
        }

        private static void SortCommand(string[] args, List<string> collection)
        {
            int startIndex = int.Parse(args[2]);
            if (startIndex!=collection.Count)
            {
                int count = int.Parse(args[4]);
                collection.Sort(startIndex, count, StringComparer.InvariantCulture);
            }
        }

        private static void ReverseCommand(string[] args, List<string> collection)
        {
            int startIndex = int.Parse(args[2]);
            if (startIndex != collection.Count)
            {
                int count = int.Parse(args[4]);
                collection.Reverse(startIndex, count);
            }
        }
    }
}
