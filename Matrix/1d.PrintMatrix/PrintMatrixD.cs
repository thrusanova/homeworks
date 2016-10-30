//Write a program that fills and prints a matrix of size (n, n) as shown below:
//1 12 11 10 
//2 13 16 9 
//3 14 15 8 
//4 5 6 7 

using System;
 class PrintMatrixD
    {
        static void Main()
     {
            Console.WriteLine("Enter the size of the matrix n=:");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int row = 0;
            int col = 0;
            string direction = "down";
            int lenght = n * n;

            for (int i = 1; i <=lenght; i++)
            {
                if (direction == "down" && (row > n - 1 || matrix[row,col]!=0))
                {
                    direction = "right";
                    row--;
                    col++;     
                }
                if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
                {
                    direction = "up";
                    col--;
                    row--;
                }
                if (direction == "up" && (row < 0 || matrix[row, col] != 0))
                {
                    direction = "left";
                    row++;
                    col--; 
                }
                if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                {
                    direction = "down";
                    col++;
                    row++;
                }
                matrix[row, col] = i;
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "right")
                {
                    col++;
                }
                if (direction == "up")
                {
                    row--;
                }
                if (direction == "left")
                {
                    col--;
                }
            }
            //print
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,4}",matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
