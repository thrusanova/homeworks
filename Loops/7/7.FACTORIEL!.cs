//In combinatorics, the number of ways to choose  k  different members out of a group of  n  different elements 
//(also known as the number of combinations) is calculated by the following formula: formula For example, 
//there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
// Your task is to write a program that calculates  n! / (k! * (n-k)!)  for given  n  and  k  (1 < k < n < 100).
//Try to use only two loops.

using System;
using System.Numerics;
    class factoriel
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            BigInteger result =1;
            BigInteger result2 =1;
              BigInteger finalResult;
        
            for (int i = (K + 1); i <= N;i++)
            {
                result *= i;
            }
            
                for (int j = 1; j <= (N - K); j++)
                {
                    result2 *= j;
                }  
        finalResult =(BigInteger)(result / result2);
        Console.WriteLine(finalResult);

        }
    }
    
