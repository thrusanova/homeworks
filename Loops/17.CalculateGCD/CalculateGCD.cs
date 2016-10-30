//Write a program that calculates the greatest common divisor (GCD) of given two integers  a  and  b .
//Use the Euclidean algorithm (find it in Internet).

using System;
 class CalculateGCD
    {
    static int GCD(int a, int b)
    {
        return b == 0 ? a : GCD(b, a % b);
    }
    static void Main()
        {
        string [] str = Console.ReadLine().Split(' ');
            int a = int.Parse(str[0]);
            int b = int.Parse(str[1]);
        int z = GCD(a, b);
        Console.WriteLine(z);

    }
    }


