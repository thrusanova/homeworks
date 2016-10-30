//Write a program to calculate  n!  for each  n  in the range [ 1..100 ].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number

using System;
using System.Numerics;
    class NFactoriel
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(Factoriel(i));
            } 
        }
        static BigInteger Factoriel(BigInteger number)
        {
            BigInteger product = 1;
            for (int i = 1; i <= number; i++)
            {
                product *= i;
            }
            return product;
        }
    }

