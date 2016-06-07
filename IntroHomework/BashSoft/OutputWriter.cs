
namespace BashSoft
{
    using System;

    public static  class OutputWriter
    {
        public static void WriteMessage(string message)
        {
            Console.Write(message);
        }
        public static void WriteMessageWithNewLine(string message)
        {
            Console.WriteLine(message);
        }
        public static void WriteEmptyLine(string message)
        {
            Console.WriteLine();
        }
        public static void DisplayExceptions(string message)
        {
            ConsoleColor currentColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = currentColor;
        }

    }
}
