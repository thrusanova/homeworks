// //Write a program that fills and prints a matrix of size (n, n) as shown below:
//7 11 14 16 
//4 8 12 15 
//2 5 9 13 
//1 3 6 10 

using System;
class PrintMatrixC
{
    static void Main()
    {
        Console.Write("Enter the size of the matrix n=:");
        int n = int.Parse(Console.ReadLine());
        int startRow = n - 1;
        int startCol = 0;
        int[,] matrix = new int[n, n];
        matrix[n-1, 0] = 1;
        int counter = 1;
        for (int row = n - 2; row >= 0; row--)
        {
            matrix[row, 0] = matrix[row + 1, 0] + counter;
            int newRow = row;
            for (int diagonal = 1; diagonal <= counter; diagonal++)
            {
                matrix[newRow + 1, diagonal] = matrix[newRow, diagonal - 1] + 1;
                newRow++;
            }
            counter++;
        }
        int maxRow = 0;
        int maxCol = n - 1;
        matrix[maxRow, maxCol] = n * n;
        int diagonalLength = 2;
        int currentRow = 1;
        int currentCol = n - 1;
        for (int i = 1; i < counter - 1; i++)
        {
            for (int j = 1; j <= diagonalLength; j++)
            {
                matrix[currentRow, currentCol] = matrix[maxRow, maxCol] - 1;
                maxRow = currentRow;
                maxCol = currentCol;
                currentRow--;
                currentCol--;
            }
            diagonalLength++;
            currentRow = i + 1;
            currentCol = n - 1;
        }
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}
 
