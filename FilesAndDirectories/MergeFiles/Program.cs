using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeFiles
{
    class Program
    {
        static void Main()
        {
            string [] firstFile = File.ReadAllLines("Text1.txt");
            string[] secondFile = File.ReadAllLines("Text2.txt");
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                for (int i = 0; i < firstFile.Length; i++)
                {
                    for (int j = i; j < secondFile.Length; j++)
                    {
                        writer.WriteLine("{0}", firstFile[i]);
                        writer.WriteLine("{0}", secondFile[j]);
                        break;
                    }
                }
            }

        }
    }
}
