using System;
using System.Linq;

namespace matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = dimension[0];
            int cols = dimension[1];
            int[,] matrix = new int[rows, cols];
            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j= 0; j < cols; j++)
                {
                    matrix[i, j] = count;
                    count++;
                }
            }
            string ivoCoords = Console.ReadLine();
            long result = 0;
            while (ivoCoords!= "Let the Force be with you")
            {
                int [] coord = ivoCoords.Split(' ').Select(int.Parse).ToArray();
                int[] enemyCoords = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int enemyRows = enemyCoords[0];
                int enemyCol = enemyCoords[1];

                int ivoRows = coord[0];
                int ivocols = coord[1];

                while (enemyRows>=0 && enemyCol>=0)
                {
                    if (IsInside(matrix, enemyRows, enemyCol))
                    {
                        matrix[enemyRows, enemyCol] = 0;
                    }
                    enemyRows--;
                    enemyCol--;
                }

                while (ivoRows>=0 && ivocols<matrix.GetLength(1))
                {
                    if (IsInside(matrix, ivoRows, ivocols))
                    {
                        result += matrix[ivoRows, ivocols];
                    }
                    ivoRows--;
                    ivocols++;
                }
                ivoCoords = Console.ReadLine();
            }
            Console.WriteLine(result);
        }

        private static bool IsInside(int[,] matrix, int row, int col)
        {
            bool res = row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
            return res;
        }
        
    }
}
