//  In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula 
// Write a program to calculate the  nth  Catalan number by given  n  (1 < n < 100). 

using System;
using System.Numerics;
 class CatalansNumbers

    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            BigInteger result2 = 1;
            BigInteger finalResult;
            for (int i = (2 *N); i > (N+1); i--)
            {
                result *= i;
            }
            for (int j = 1; j <= N; j++)
            {
                result2 *= j;
            }
            finalResult = result / result2;
            Console.WriteLine(finalResult);
        }
    }

