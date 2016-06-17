using System;

namespace jediGalaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dimension = Console.ReadLine().Split(' ');
            int rows = int.Parse(dimension[0]);
            int cols = int.Parse(dimension[0]);
            int[,] matrix = new int[rows, cols];
            string startPoints = Console.ReadLine();

            //    string enemyPos = Console.ReadLine();
            long result = 0;
            FillMatrix(matrix, rows, cols);
            while (startPoints!= "Let the Force be with you")
            {
                string enemyPos = Console.ReadLine();
                string [] start= startPoints.Split(' ');
                int startRow = int.Parse(start[0]);
                int startCol = int.Parse(start[1]);
                string[] enemy = enemyPos.Split(' ');
                int startEnemyRol = int.Parse(enemyPos.Split(' ')[0]);
                int startEnemyCol = int.Parse(enemyPos.Split(' ')[0]);

                while (startEnemyRol>=0 && startEnemyCol>=0)
                {
                    if (IsInside(matrix, startEnemyRol, startEnemyCol))
                    {
                        matrix[startEnemyRol, startEnemyCol] = 0;
                    }
                    startEnemyRol--;
                    startEnemyCol--;
                }
                while (startRow>=0 && startCol<matrix.GetLength(1))
                {
                    if (IsInside(matrix, startRow, startCol))
                    {
                        result += matrix[startRow, startCol];
                    }
                    startRow--;
                    startCol++;
                }

                startPoints = Console.ReadLine();
            }
            Console.WriteLine(result);
        }

        private static bool IsInside(int[,] matrix, int row, int col)
        {
            bool res = row >= 0 && row < matrix.GetLength(0) && col < matrix.GetLength(1) 
                && col >= 0;
            return res;
        }

        private static void FillMatrix(int[,] matrix, int rows, int cols)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = count;
                    count++;
                }
             
            }
        }
    }
}
