// Write a program that reads two integer numbers N and K and an array of N elements from the console
//Find in the array those K elements that have maximal sum.

using System;
class maxElement
{
    static void Main()
    {
       
        int N = int.Parse(Console.ReadLine());
        
        int K = int.Parse(Console.ReadLine());
        int[] myArr = new int[N];   
        int MaxSum = 0;
        if (N >= K)
        {
            for (int i = 0; i < N; i++)
            {
                myArr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(myArr);

            for (int i = N - K; i < N; i++)
            {
             

                MaxSum += myArr[i];
            }

            Console.WriteLine(MaxSum);
        }
     

    }
}