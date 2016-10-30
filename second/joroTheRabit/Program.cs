using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joroTheRabit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputNum = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var numbers = new int[inputNum.Length];
            for (int i = 0; i < inputNum.Length; i++)
            {
                numbers[i] = int.Parse(inputNum[i]);
            }
            int bestPath = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int step = 1; step < numbers.Length; step++)
                {
                    int index = i;
                    int currPath = 1;
                    int next = (index + step);
                    if (next>=numbers.Length)
                    {
                        next = next - numbers.Length;
                    }
                    while (numbers[index]<numbers[next])
                    {
                        currPath++;
                        index = next;
                        next = (index + step) % numbers.Length;
                    }
                    if (currPath>bestPath)
                    {
                        bestPath = currPath;
                    }
                }
            }

            Console.WriteLine(bestPath);
        }
    }
}
