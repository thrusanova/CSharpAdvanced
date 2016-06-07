using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace JavaExam23
{
    class RoyalNonStop
    {
        public struct BigDecimal
        {
            public BigInteger Integer { get; set; }
            public BigInteger Scale { get; set; }

            public BigDecimal(BigInteger integer, BigInteger scale) : this()
            {
                Integer = integer;
                Scale = scale;
                while (Scale > 0 && Integer % 10 == 0)
                {
                    Integer /= 10;
                    Scale -= 1;
                }
            }

            public static implicit operator BigDecimal(decimal a)
            {
                BigInteger integer = (BigInteger)a;
                BigInteger scale = 0;
                decimal scaleFactor = 1m;
                while ((decimal)integer != a * scaleFactor)
                {
                    scale += 1;
                    scaleFactor *= 10;
                    integer = (BigInteger)(a * scaleFactor);
                }
                return new BigDecimal(integer, scale);
            }

            public static BigDecimal operator *(BigDecimal a, BigDecimal b)
            {
                return new BigDecimal(a.Integer * b.Integer, a.Scale + b.Scale);
            }

            public override string ToString()
            {
                string s = Integer.ToString();
                if (Scale != 0)
                {
                    if (Scale > Int32.MaxValue) return "[Undisplayable]";
                    int decimalPos = s.Length - (int)Scale;
                    s = s.Insert(decimalPos, decimalPos == 0 ? "0." : ".");
                }
                return s;
            }
        }

        static void Main()
        {
            string[] dimensions = Console.ReadLine().Split(' ');
            string[] prices = Console.ReadLine().Split(' ');
            int rows = int.Parse(dimensions[0]);
            int cols = int.Parse(dimensions[1]);
            decimal lucankaPrice = decimal.Parse(prices[0]);
            decimal rakiaPrice = decimal.Parse(prices[1]);
            string input = Console.ReadLine();
            char[,] matrix = new char[rows, cols];
            decimal result = 0;
            long sum = 0;
            int count = 0;
            FillMatrix(matrix);
            //  PrintMatrix(matrix);
            while (input != "Royal Close")
            {
                count++;
                string[] str = input.Split(' ');
                int currRow = int.Parse(str[0]);
                int currCol = int.Parse(str[1]);
                if (currRow < currCol)
                {
                    for (int i = currRow + 1; i >= 1; i--)
                    {
                        if (i % 2 == 0)
                        {
                            result += rakiaPrice * i * (currCol + 1);
                        }
                        else
                        {
                            result += lucankaPrice * i *(currCol+1);
                        }
                    }
                    
                    for (int i = currCol; i >= 2; i--)
                    {
                        
                            result += lucankaPrice * i;
                        
                    }
                }
                else
                {
                    for (int i = currCol+1 ; i >= 1; i--)
                    {
                        if (currRow % 2 == 0)
                        {
                            result += lucankaPrice * (currRow + 1) * i;
                        }
                        else
                        {
                            result += rakiaPrice * (currRow + 1) * i;
                        }
                    }
                 
                    for (int i = currRow; i >= 2; i--)
                    {
                        if (i % 2 == 0)
                        {
                            result += rakiaPrice * i;
                        }
                        else
                        {
                            result += lucankaPrice * i;
                        }
                    }
                   
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("{0:F6}", result);
            Console.WriteLine(count);
        }

        private static void FillMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i % 2 == 0)
                    {
                        matrix[i, j] = 'L';
                    }
                    else
                    {
                        matrix[i, j] = 'R';
                    }
                }
            }
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}