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
        byte[,] matrix = new byte[N, N];
        for (int row = 0; row < N; row++)
        {
            var line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int col = 0; col < line.Length; col++)
            {
                matrix[row, col] = byte.Parse(line[col]);
            }
        
        }
        Console.WriteLine(SolveProble(matrix));
    }

    private static int SolveProble(byte[,] matrix)
    {
        int result = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                switch (matrix[row, col])
                {
                    case 1: result += OnePattern(matrix, row, col); break;
                    case 2: result += TwoPattern(matrix, row, col); break;
                    case 3: result += ThreePattern(matrix, row, col); break;
                    case 4: result += FourPattern(matrix, row, col); break;
                    case 5: result += FivePattern(matrix, row, col); break;
                    case 6: result += SixPattern(matrix, row, col); break;
                    case 7: result += SevenPattern(matrix, row, col); break;
                    case 8: result += EightPattern(matrix, row, col); break;
                    case 9: result += NinPattern(matrix, row, col); break;
                    // case 0: result += ZeroPattern(matrix, row, col); break;
                }
            }
        }
        return result;
    }

    //  private static int ZeroPattern(int[,] matrix, int row, int col)
    // {
    //  bool isZeroPattern = row >= 0 && row < matrix.GetLength(0) &&
    //col >=0 && col < matrix.GetLength(1) &&
    //    matrix[row, col] == 0 && matrix[row, col + 1] == 0
    // && matrix[row, col + 2] == 0 && matrix[row + 1, col] == 0
    // && matrix[row + 1, col + 2] == 0 && matrix[row + 2, col] == 0
    // && matrix[row + 3, col] == 0 && matrix[row + 3, col + 2] == 0
    //  && matrix[row + 4, col] == 0 && matrix[row + 4, col + 2] == 0;
    // return (isZeroPattern) ? 0 : 0;

    // }

    private static int OnePattern(byte[,] matrix, int row, int col)
    {
        bool isOneoPattern = row >= 0 && row < matrix.GetLength(0) - 4 &&
                         col >= 2 && col < matrix.GetLength(1) &&
                         matrix[row, col] == 1 && matrix[row + 1, col - 1] == 1
                         && matrix[row + 2, col - 2] == 1 && matrix[row + 1, col] == 1
                         && matrix[row + 2, col] == 1 && matrix[row + 3, col] == 1 &&
                         matrix[row + 4, col] == 1;
        return isOneoPattern ? 1 : 0;

    }
    private static int TwoPattern(byte[,] matrix, int row, int col)
    {
        bool isTwoPattern = row >= 0 && row < matrix.GetLength(0) - 4 &&
                                      col >= 1 && col < matrix.GetLength(1) - 1 &&
                                      matrix[row, col] == 2 &&
                                      matrix[row + 1, col - 1] == 2 &&
                                      matrix[row + 1, col + 1] == 2 &&
                                      matrix[row + 2, col + 1] == 2 &&
                                      matrix[row + 3, col] == 2 &&
                                     matrix[row + 3, col] == 2 &&
                                      matrix[row + 4, col - 1] == 2 &&
                                      matrix[row + 4, col] == 2 &&
                                      matrix[row + 4, col + 1] == 2;
        return isTwoPattern ? 2 : 0;

    }
    private static int ThreePattern(byte[,] matrix, int row, int col)
    {
        bool isThreePattern = row >= 0 && row < matrix.GetLength(0) - 4 &&
                         col >= 2 && col < matrix.GetLength(1) &&
                         matrix[row, col] == 3 && matrix[row, col - 1] == 3
                         && matrix[row + 1, col] == 3 && matrix[row + 2, col] == 3
                         && matrix[row + 2, col - 1] == 3 && matrix[row + 3, col] == 3 &&
                          matrix[row + 4, col - 2] == 3
                         && matrix[row + 4, col - 1] == 3 && matrix[row + 4, col] == 3;
        return isThreePattern ? 3 : 0;

    }
    private static int FourPattern(byte[,] matrix, int row, int col)
    {
        bool isFourPattern = row >= 0 && row < matrix.GetLength(0) - 4 &&
                         col >= 2 && col < matrix.GetLength(1) &&
                         matrix[row, col] == 4 && matrix[row, col - 2] == 4 &&
                         matrix[row + 1, col - 2] == 4 &&
                         matrix[row + 1, col] == 4 && matrix[row + 2, col - 2] == 4
                         && matrix[row + 2, col - 1] == 4 && matrix[row + 2, col] == 4 &&
                         matrix[row + 3, col] == 4 && matrix[row + 4, col] == 4;
        return isFourPattern ? 4 : 0;
    }
    private static int FivePattern(byte[,] matrix, int row, int col)
    {
        bool isFivePattern = row >= 0 && row < matrix.GetLength(0) - 4 &&
                         col >= 2 && col < matrix.GetLength(1) &&
                         matrix[row, col] == 5 && matrix[row, col -1] == 5 && matrix[row, col - 2] == 5
                         && matrix[row+1, col-2 ] == 5 
                         && matrix[row + 2, col - 2] == 5 && matrix[row + 2, col- 1] == 5
                         && matrix[row + 2, col] == 5 &&
                         matrix[row + 3, col-2] == 5 &&
                         matrix[row + 4, col] == 5
                         && matrix[row + 4, col-1] == 5 &&
                         matrix[row + 4, col - 2] == 5;
        return isFivePattern ? 5 : 0;
    }
    private static int SixPattern(byte[,] matrix, int row, int col)
    {
        bool isSixPattern = row >= 0 && row < matrix.GetLength(0) - 4 &&
                         col >= 2 && col < matrix.GetLength(1) &&
                         matrix[row, col] == 6 && matrix[row, col - 2] == 6 && matrix[row + 1, col - 2] == 6
                         && matrix[row + 2, col - 2] == 6 && matrix[row + 2, col - 1] == 6
                         && matrix[row + 2, col] == 6 && matrix[row + 3, col - 2] == 6
                         && matrix[row + 3, col] == 6 && matrix[row + 4, col] == 6 &&
                         matrix[row + 4, col - 2] == 6 && matrix[row + 4, col - 1] == 6;
        return isSixPattern ? 6 : 0;
    }
    private static int SevenPattern(byte[,] matrix, int row, int col)
    {
        bool isSevenPattern = row >= 0 && row < matrix.GetLength(0) - 4 &&
                         col >= 0 && col < matrix.GetLength(1) - 2 &&
                         matrix[row, col] == 7 &&
                         matrix[row, col + 1] == 7 &&
                         matrix[row, col + 2] == 7
                         && matrix[row + 1, col + 2] == 7
                         && matrix[row + 2, col + 1] == 7
                         && matrix[row + 3, col + 1] == 7
                         && matrix[row + 4, col + 1] == 7;
        return isSevenPattern ? 7 : 0;
    }
    private static int EightPattern(byte[,] matrix, int row, int col)
    {
        bool isEightPattern = row >= 0 && row < matrix.GetLength(0) - 4 &&
                         col >= 0 && col < matrix.GetLength(1)-2 &&
                         matrix[row, col] == 8 && matrix[row, col + 1] == 8 && matrix[row, col + 2] == 8
                         && matrix[row + 1, col + 2] == 8 && matrix[row + 1, col] == 8
                         && matrix[row + 2, col + 1] == 8 && matrix[row + 3, col + 2] == 8
                         && matrix[row + 3, col] == 8 && matrix[row + 4, col] == 6 &&
                         matrix[row + 4, col + 1] == 8 && matrix[row + 4, col + 2] == 8;
        return isEightPattern ? 8 : 0;
    }
    private static int NinPattern(byte[,] matrix, int row, int col)
    {
        bool isNinPattern = row >= 0 && row < matrix.GetLength(0) - 4 &&
                                       col >= 0 && col < matrix.GetLength(1) - 2 &&
                                       matrix[row, col] == 9 &&
                                       matrix[row, col + 1] == 9 &&
                                       matrix[row, col + 2] == 9 &&
                                       matrix[row + 1, col + 2] == 9 &&
                                       matrix[row + 2, col + 2] == 9 &&
                                       matrix[row + 2, col + 1] == 9 &&
                                       matrix[row + 1, col] == 9 &&
                                       matrix[row + 3, col + 2] == 9 &&
                                       matrix[row + 4, col + 2] == 9 &&
                                       matrix[row + 4, col + 1] == 9 &&
                                       matrix[row + 4, col] == 9;

        return isNinPattern ? 9 : 0;

    }
}


