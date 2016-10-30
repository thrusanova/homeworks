using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] numbers = Console.ReadLine().Split(' ');
            int rows = int.Parse(numbers[0]);
            int cols = int.Parse(numbers[1]);
            int[,] coins = new int[rows, cols];
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                string []coord = Console.ReadLine().Split(' ');
                int x = int.Parse(coord[0]);
                int y = int.Parse(coord[1]);
                coins[x, y]++;
            }
            int[,] dp = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    int maxAbove = 0;
                    int maxLeft = 0;
                    if (row-1>=0)
                    {
                        maxAbove = dp[row - 1, col];
                    }
                    if (col-1>=0)
                    {
                        maxLeft = dp[row, col - 1];
                    }
                    dp[row, col] = Math.Max(maxAbove, maxLeft) + coins[row, col];
                }
            }
            Console.WriteLine(dp[rows-1,cols-1]);
        }
    }
}
