using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[10, 10];
        int[,] newMatrix = new int[10, 10];
        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            matrix[x, y] = 1;
        }
        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                int count = 0;
                count += CheckLifes(matrix, row, col, -1, 0);
                count += CheckLifes(matrix, row, col, -1, -1);
                count += CheckLifes(matrix, row, col, -1, 1);
                count += CheckLifes(matrix, row, col, 1, 0);
                count += CheckLifes(matrix, row, col, 1, 1);
                count += CheckLifes(matrix, row, col, 1, -1);
                count += CheckLifes(matrix, row, col, 0, -1);
                count += CheckLifes(matrix, row, col, 0, 1);
                if ((count == 3 || count == 2) && (matrix[row, col] == 1))
                {
                    newMatrix[row, col] = 1;
                }
                else if (count == 3 && matrix[row, col] == 0)
                {
                    newMatrix[row, col] = 1;
                }
            }
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = 9; j >= 0; j--)
            {
                Console.Write(newMatrix[i, j]);
            }
            Console.WriteLine();
        }

    }
    private static int CheckLifes(int[,] matrix, int row, int col, int p1, int p2)
    {
        int count = 0;
        row += p1;
        col += p2;
        if (row >= 0 && row < 10 && col >= 0 && col < 10 && matrix[row, col] == 1)
        {
            count = 1;
        }
        return count;
    }
    //  }

}
 