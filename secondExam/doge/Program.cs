using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace doge
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] size = Console.ReadLine().Split();
            int N = int.Parse(size[0]);
            int M = int.Parse(size[1]);
            BigInteger[,] matrix = new BigInteger[N, M];
            string[] bone = Console.ReadLine().Split();
            int Fx = int.Parse(bone[0]);
            int Fy = int.Parse(bone[1]);
            int K = int.Parse(Console.ReadLine());
            HashSet<string> enemies = new HashSet<string>();
            for (int col = 0; col < K; col++)
            {
                string enem = Console.ReadLine();
                var enemy = enem.Split();
                enemies.Add(int.Parse(enemy[0]) + " " + int.Parse(enemy[1]));

            }
            matrix[0, 0] = 1;
            for (int row = 0; row <= Fx; row++)
            {
                for (int col = 0; col <= Fy; col++)
                {
                    if (enemies.Contains(row+" "+col))
                    {
                        continue;
                    }
                    if (row!=0)
                    {
                        matrix[row, col] += matrix[row - 1, col];
                    }
                    if (col!=0)
                    {
                        matrix[row, col] += matrix[row, col - 1];
                    }
                }
            }

            Console.WriteLine(matrix[Fx,Fy]);
        }
    }
}