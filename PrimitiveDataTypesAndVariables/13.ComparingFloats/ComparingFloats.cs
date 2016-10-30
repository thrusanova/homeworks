//Write a program that safely compares floating-point numbers (double) with precision  eps = 0.000001 
using System;
class ComparingFloats
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double eps = 0.000001;
        if (Math.Abs(a - b) <= eps)
        {
            Console.WriteLine("The numbers are  equal");
        }
        else
        {
            Console.WriteLine("The numbers are not equal");
        }
    }
}


