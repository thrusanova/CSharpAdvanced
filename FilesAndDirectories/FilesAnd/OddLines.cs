
namespace FilesAnd
{
    using System;
    using System.IO;

  public  class OddLines
    {
     public   static void Main(string[] args)
        {
          var output = File.ReadAllLines("input.txt");
            for (int i = 0; i < output.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(output[i]);
                }
            }
        }
    }
}
