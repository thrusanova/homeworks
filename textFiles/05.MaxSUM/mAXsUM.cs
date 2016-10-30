//Write a program that reads a text file containing a square matrix of numbers.
// Find an area of size  2 x 2  in the matrix, with a maximal sum of its elements. ◦ The first line in the input file contains the size of matrix  N .
//◦ Each of the next  N  lines contain  N  numbers separated by space.
//◦ The output should be a single number in a separate text file.


using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaxSUM
{
    class mAXsUM
    {
        static void Main(string[] args)
        {
            StreamReader readMatrix = new StreamReader(@"..\..\MaximalSum.cs");
            using (readMatrix)
            {
                int dimension = int.Parse(readMatrix.ReadLine());
                int[,] matrix = new int[dimension, dimension];
                for (int rows = 0; rows < matrix.GetLength(0); rows++)
                {
                    string[] numbersOnLine = readMatrix.ReadLine().Split(' ');
                    for (int cols = 0; cols < matrix.GetLength(1); cols++)
                    {
                        matrix[rows, cols] = int.Parse(numbersOnLine[cols]);
                    }
                }
                int maximalSum = int.MinValue;
                for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
                {
                    for (int cols = 0; cols < matrix.GetLength(1) - 1; cols++)
                    {
                        maximalSum = Math.Max(maximalSum, matrix[rows, cols] + matrix[rows, cols + 1] + matrix[rows + 1, cols] + matrix[rows + 1, cols + 1]);
                    }
                }
                StreamWriter sum = new StreamWriter(@"..\..\sum.txt");
                using (sum)
                {
                    sum.WriteLine(maximalSum);
                }

            }
        }
    }
}
