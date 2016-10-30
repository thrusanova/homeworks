using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GreedyDwarf
{
    class Program
    {

        static int[] FillArray(string[] stringArray)
        {
            int[] arrayInt = new int[stringArray.Length];
            for (int i = 0; i < stringArray.Length; i++)
            {
                arrayInt[i] = int.Parse(stringArray[i]);
            }
            return arrayInt;
        }


        static void Main()
        {
            string[] inputValley = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] valley =  FillArray( inputValley);

            int m = int.Parse(Console.ReadLine());

            long maxResult = long.MinValue;
           
                for (int path = 0; path < m; path++)
                {
                    string[] inputPattern = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    int[] pattern = FillArray(inputPattern);

                       bool[] boolValley = new bool[inputValley.Length];
                    int indexValley = 0;
                    boolValley[indexValley] = true;
                    long currentResult = valley[indexValley];
                    int col = 0;
                    while (true)
                    {
                        indexValley += pattern[col];
                        if (indexValley >= valley.Length || indexValley < 0)
                        {
                            break;
                        }
                        else
                        if (boolValley[indexValley] == false )
                        {
                            currentResult += valley[indexValley];
                            boolValley[indexValley] = true;
                        }
                        else
                        {
                            break;
                        }
                        col++;
                        if (col == pattern.Length)
                        {
                            col = 0;
                        }
                    }


                    if (currentResult > maxResult)
                    {
                        maxResult = currentResult;
                    }

                }
                Console.WriteLine(maxResult);
           

        }
    }
}