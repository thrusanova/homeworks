using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{

    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        long[,] matrix = new long[N, N];
        for (int row = 0; row < N; row++)
        {
            var line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int col = 0; col < line.Length; col++)
            {
                matrix[row, col] = long.Parse(line[col]);
            }
        }
         Console.WriteLine(Solve(matrix));
    }
        public static string Solve(long[,] matrix)
        {
            long maxSum = int.MinValue;
            bool isSumFound = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (IsPattern(matrix, row, col))
                    {
                        long patternSum = SumOfMatrix(matrix, row, col);
                        if (maxSum < patternSum)
                        {
                            maxSum = patternSum;
                        }
                        isSumFound = true;
                    }
                }
            }

            if (isSumFound)
            {
                return string.Format("YES {0}", maxSum);
            }
            else
            {
                long diagonalSum = 0;
                for (int index = 0; index < matrix.GetLength(0); index++)
                {
                    diagonalSum += matrix[index, index];
                }

                return string.Format("NO {0}", diagonalSum);
            }
        }
        private static bool IsPattern (long[,] matrix, int row, int col)
        {
            if (row + 2 >= matrix.GetLength(0) || col + 4 >= matrix.GetLength(1))
            {
                return false;
            }

            var result=matrix[row, col + 1] == matrix[row, col] + 1//1 2
                    && matrix[row, col + 2] == matrix[row, col + 1] + 1//2 3
                    && matrix[row + 1, col + 2] == matrix[row, col + 2] + 1// 3 4
                     && matrix[row + 2, col + 2] == matrix[row + 1, col + 2] + 1//4 5
                      && matrix[row + 2, col + 3] == matrix[row + 2, col + 2] + 1
                      && matrix[row + 2, col + 4] == matrix[row + 2, col + 3] + 1;
            
                return result;
            }

    
    private static long SumOfMatrix(long[,]matrix,int row,int col)
{
       long sum = 0;
                     sum += matrix[row, col];
                     sum += matrix[row, col + 1];
                    sum+= matrix[row, col + 2];
                    sum += matrix[row + 1, col + 2];
                    sum += matrix[row + 2, col + 2];
                    sum += matrix[row + 2, col + 3];
                   sum+= matrix[row + 2, col + 4];
    return sum;
}
}
