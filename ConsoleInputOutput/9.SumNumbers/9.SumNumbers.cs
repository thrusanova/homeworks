//Write a program that enters a number  n  and after that enters more  n  numbers and calculates and prints their  sum . 
using System;
    class SumNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1;i<=n;i++)
            {
                sum+=  double.Parse(Console.ReadLine());
               
            }
            Console.WriteLine(sum);
        }
    }

