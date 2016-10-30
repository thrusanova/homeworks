using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quitar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songStr = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int [] song=new int[songStr.Length];
            for (int i = 0; i < songStr.Length; i++)
            {
                song[i] = int.Parse(songStr[i]);
            }
            int start = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int[,] matrix=new int [song.Length+1,max+1];
            matrix[0, start] = 1;
            for (int row = 1; row < matrix.GetLength(0); row++)
            {
               int interval = song[row - 1];
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row-1,col]==1)
                    {
                        if (col - interval >= 0)
                        {
                            matrix[row, col - interval] = 1;
                        }
                        if (col + interval <= max)
                        {
                            matrix[row, col + interval] = 1;
                        }
                    }
                }
            }
            for (int i = max;i>=0; i--)
            {
                if (matrix[song.Length,i]==1)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine(-1);
        }
    }
}
