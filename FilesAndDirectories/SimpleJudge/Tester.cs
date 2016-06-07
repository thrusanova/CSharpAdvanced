
namespace SimpleJudge
{
    using System;
    using System.Collections.Generic;
    using System.IO;

   public class Tester
    {
        public static void CompareContent(string userOutputPath,string expectedOutputPath)
        {
         
        }

        private static string GetMishmashPath(string expectedOutputPath)
        {
            int indexOf = expectedOutputPath.LastIndexOf('\\');
            string directoryPath = expectedOutputPath.Substring(0, indexOf);
            string finalPath = directoryPath + @"\Misnmatches.txt";
            return finalPath;

        }
    }
}
