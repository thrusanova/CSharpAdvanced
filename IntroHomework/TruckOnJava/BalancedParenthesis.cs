using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckOnJava
{
    class BalancedParenthesis
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isBalanced = false;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                sb.Append(input[i]);
            }
            var leftQueue = new Queue<char>();
            var rightStack = new Stack<char>();
            if (sb.Length % 2 == 0)
            {
                for (int i = 0; i < sb.Length/2; i++)
                {
                    leftQueue.Enqueue(sb[i]);
                }
                for (int i = sb.Length/2; i < sb.Length; i++)
                {
                    rightStack.Push(sb[i]);
                }
                if (leftQueue.Count==0 || rightStack.Count == 0)
                {
                    isBalanced = false;
                }
                while (leftQueue.Count > 0)
                {
                    char ch = leftQueue.Dequeue();
                    char c = rightStack.Pop();
                    if ((ch=='(' && c==')') || (ch == '[' && c == ']') || (ch == '{' && c == '}') || (ch==' ' && c==' '))
                    {
                        isBalanced = true;
                    }
                    else
                    {
                        isBalanced = false;
                    }
                 
                }
               
                
            }
            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }


        }
    }

}

