// Write a program that calculates  n! / k!  for given  n  and  k  (1 < k < n < 100).
// Use only one loop.
using System;
using System.Numerics;
class Factoriel
    {
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        BigInteger result = 1;
       var arr = new int[N - K];
        for (int i = 0; i <arr.Length; i++)
        {
            arr[i] = N;
            N--;
            result *= arr[i];
        }
        Console.WriteLine(result);
    }
    }

//1.2.3.4.5/1.2.3.4.5.6