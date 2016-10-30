﻿//Write a program that fills and prints a matrix of size (n, n) as shown below:
//1 8 9 16 
//2 7 10 15 
//3 6 11 14 
//4 5 12 13 

using System;
class PrintMatrixB
{
    static void Main()
    {
        Console.Write("Enter the size of the matrix:");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int count = 1;
        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = count;
                    count++;
                }
            }
            else
            {
                for (int row = n-1; row >= 0; row--)
                {
                    matrix[row, col] = count;
                    count++;
                }
            }
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
