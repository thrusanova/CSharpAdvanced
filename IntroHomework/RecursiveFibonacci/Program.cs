using System;

namespace RecursiveFibonacci
{
    class Program
    {
     public  static long [] array;
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            array = new long[number+2];
            array[1] = 1;
            array[2] = 1;
            Console.WriteLine(FibonacciNumber(number));
        }

        public static long FibonacciNumber(long number) 
        {
            if (array[number] ==0)

            {
                array[number] = FibonacciNumber(number - 1) + FibonacciNumber(number - 2);
            }
            return array[number];
           
        }
    }
}
