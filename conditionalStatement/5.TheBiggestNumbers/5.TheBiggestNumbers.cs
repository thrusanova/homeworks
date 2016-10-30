//Write a program that finds the biggest of three numbers.
using System;
    class TheBiggestNumbers
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double result = Math.Max(a,c);
            double finalResult = Math.Max(result,b);
            Console.WriteLine(finalResult);
        }
    }
