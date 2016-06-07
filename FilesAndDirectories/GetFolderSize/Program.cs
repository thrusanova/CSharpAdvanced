using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GetFolderSize
{
    class Program
    {
        static double ConvertBytesToMegabytes(long bytes)
        {
            return (bytes / 1024f) / 1024f;
        }
        static void Main(string[] args)
        {
            string[] str = Directory.GetFiles("C:\\Users\\tanya\\Documents\\Visual Studio 2015\\Projects\\FilesAnd\\GetFolderSize");
            long size = 0;
            foreach (var file in str)
            {
                FileInfo f = new FileInfo(file);
                long s1 = f.Length;
                size += s1;
            }
            Console.WriteLine(ConvertBytesToMegabytes(size));
        }

    }
}