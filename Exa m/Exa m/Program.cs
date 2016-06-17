using System;
using System.Collections.Generic;
using System.Text;

namespace Exa_m
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();
            bool isY = false;
            string mStr = "";
            string pStr = "";
            string kStr = "";
            string t = "";
            string c = "";
            var list = new Queue<string>();
            for (int i = 0; i < number; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                var st = new StringBuilder(str.ToString());
               
             
               
                for (int j = 0; j < str.Length; j += 1)
                {
                    string s = str[j];
                    char letter = s[0];
                    int num = int.Parse(s[1].ToString());
                    switch (letter)
                    {
                        case 'm': mStr += s + " "; break;
                        case 'k': kStr += s + " "; break;
                        case 'p': pStr += s + " "; break;
                        case 's': t += s + " "; break;
                        case 't': t += s + " "; break;
                        case 'y': isY = true; break;

                    }
                }
            }
                if (isY == false)
                {
                  

                list.Enqueue(t);

                list.Enqueue(mStr);

                list.Enqueue(kStr);

                list.Enqueue(pStr);

                }
                else
                {
                list.Enqueue(mStr);

                list.Enqueue(kStr);

               

                list.Enqueue(t);

                list.Enqueue(pStr);

                }
        
           Console.WriteLine(string.Join("",list));
        }
          
        }
    }


