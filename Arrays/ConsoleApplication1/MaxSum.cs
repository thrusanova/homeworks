//Write a program that finds the sequence of maximal sum in given array. Example:
	//{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
	//Can you do it with only one loop (with single scan through the elements of the array)?

using System;
    class MaxSum
    {
        static void Main()
        {
        int N = int.Parse(Console.ReadLine());
        int[] arr = new int[N];
      
            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int currentSum = arr[0];
            int startIndex = 0;
            int lastIndex = 0;
            int currentIndex = 0;
            int maxSum = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (currentSum < 0)
                {
                    currentSum = arr[i];
                    currentIndex = i;
                }
                else
                {
                    currentSum += arr[i];
                }
                if (currentSum>maxSum)
                {
                    maxSum = currentSum;
                    startIndex = currentIndex;
                    lastIndex = i;
                }
            }
            Console.WriteLine(maxSum);

        }
    }