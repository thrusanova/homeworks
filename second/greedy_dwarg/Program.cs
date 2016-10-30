using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greedy_dwarg
{
    class Program

    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char [] delimiter=new char[] { ',', ' ' };
            string [] numbers= input.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
            int[] valley = FillArray(numbers);
            long maxRes = long.MinValue;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string [] strPattern = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int[] patern = FillArray(strPattern);
                bool [] boolValley = new bool[valley.Length];
                int indexVall = 0;
                boolValley[indexVall] = true;
                int currResult = valley[indexVall];
                int col=0;
                while (true)
                {
                    indexVall += patern[col];// try
                    if (indexVall>=valley.Length || indexVall<0 )
                    {
                        break;
                    }
                    else if (boolValley[indexVall]==false)
                    {
                        currResult += valley[indexVall];
                        boolValley[indexVall] = true;

                    }
                    else
                    {
                        break;
                    }
                    col++;
                    if (col>=patern.Length)
                    {
                        col = 0;
                    }
                }
                if (currResult>maxRes)
                {
                    maxRes = currResult;
                }
               
               
            }

            Console.WriteLine(maxRes);
        }

        private static int[] FillArray(string[] numbers)
        {
            int[] ArrInt = new int[numbers.Length];
           for (int i = 0; i < numbers.Length; i++)
			{
                ArrInt[i] = int.Parse(numbers[i]);
			}
           return ArrInt;
        }
    }
}
