//• We are given a matrix of strings of size  N x M . Sequences in the matrix we define as sets of several 
//neighbour elements located on the same line, column or diagonal.
//• Write a program that finds the longest sequence of equal strings in the matrix
//
using System;

class SequenceNMatrix
{
    static void Main()
    {
        string[,] matrix = new string[,]    {{"op","op","xx","ha"}, 
                                             {"xx","xx","ha","xx"}, 
                                             {"hi","ha","hi","op"}, 
                                             {"ha","xx","hi","op"}};

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 5}", matrix[row, col]);
            }
            Console.WriteLine();
        }

        int longestSequence = 0;
        string bestElem = string.Empty;
        //horizontally
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int currentSequence = 1;
                string currentElement = matrix[row, col];
                while (col < matrix.GetLength(1) - 1 && matrix[row, col] == matrix[row, col + 1])
                {
                    currentSequence++;
                    col++;
                }
                if (currentSequence > longestSequence)
                {
                    longestSequence = currentSequence;
                    bestElem = currentElement;
                }
            }

        }
        //vertically
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int currentSequence = 1;
                string currentElement = matrix[row, col];
                while (row < matrix.GetLength(0) - 1 && matrix[row, col] == matrix[row + 1, col])
                {
                    currentSequence++;
                    row++;
                }
                if (currentSequence > longestSequence)
                {
                    longestSequence = currentSequence;
                    bestElem = currentElement;
                }
            }
        }

        //first diagonal
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int currentSequence = 1;
                string currentElement = matrix[row, col];
                while (row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1 &&
                    matrix[row, col] == matrix[row + 1, col + 1])
                {
                    currentSequence++;
                    row++;
                    col++;
                }
                if (currentSequence > longestSequence)
                {
                    longestSequence = currentSequence;
                    bestElem = currentElement;
                }
            }
        }

        //second diagonal
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = matrix.GetLength(1) - 1; col > 0; col--)
            {
                int currentSequence = 1;
                string currentElement = matrix[row, col];
                while (row < matrix.GetLength(0) - 1 && col > 0 && matrix[row, col] == matrix[row + 1, col - 1])
                {
                    currentSequence++;
                    row++;
                    col--;
                }
                if (currentSequence > longestSequence)
                {
                    longestSequence = currentSequence;
                    bestElem = currentElement;
                }
            }
        }
        Console.WriteLine(@"The longest sequence consists {0} elements of type ""{1}"".", longestSequence, bestElem);
    }
}

