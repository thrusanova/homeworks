//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}
using System;
  class SumInArray
    {
        static void Main()
        {
            int[] arr = { 4, 3, 1, 4, 2, 5, 8 };
            int Sum = 11;
            int currentSum = 0; ;
            int startIndex = 0;
            int endIndex = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                currentSum += arr[i];
                startIndex = i;
                for (int j = i+1; j < arr.Length; j++)
                {
                    currentSum += arr[j];
                    endIndex = j;
                    if (currentSum==Sum)
                    {
                        for (int seq = startIndex; seq <= endIndex; seq++)
                        {
                            Console.Write(arr[seq]+" ");
                        }
                        Console.WriteLine();
                    }

                }
                currentSum = 0;
            }
            
        }
    }

