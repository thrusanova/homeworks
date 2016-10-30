//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn.
//Use only one loop. Print the result with 5 digits after the decimal point.
using System;
    class CalculateSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double power;
           double factoriel = 1;
            double sum = 1;
            for (int i = 1; i <= n; i++)
            {
                power = Math.Pow(x, i);
                factoriel *= i;
                sum += factoriel / power; 
            }
            Console.WriteLine("{0:F5}",sum);

        }
    }
