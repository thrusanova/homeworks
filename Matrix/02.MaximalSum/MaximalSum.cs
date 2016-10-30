//Write a program that reads a rectangular matrix of size  N x M  and finds in it the square  3 x 3  that has maximal sum of its elements.
using System;
   class MaximalSum
    {
        static void Main()
        { 
            //input
            Console.Write("Enter N=");
            int N = int.Parse(Console.ReadLine());       
           Console.Write("Enter M=");
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a matrix with {0} rows and {1} cols:",N,M);
            int[,] matrix = new int[N, M];
            for (int row = 0; row < N; row++)
            {
                string input = Console.ReadLine();
                string[] strNumber = input.Split(' ');
                for (int col = 0; col < M; col++)
                {
                    matrix[row, col] = int.Parse(strNumber[col]);
                }
            }
            int currentSum = 0;
            int maxSum = 0;
            int maxPosX = 0;
            int maxPosY = 0;
            // find square
            for (int row = 0; row <= N - 3; row++)
            {
                for (int col = 0; col <= M - 3; col++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            currentSum += matrix[row+i,col+j];
                        }
                    }

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxPosX = col;
                        maxPosY = row;
                    }
                    currentSum = 0;
                }
            }
            // output
            for (int row = maxPosY; row < maxPosY + 3; row++)
            {
                for (int col = maxPosX; col < maxPosX + 3; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }

            }
        }
    
