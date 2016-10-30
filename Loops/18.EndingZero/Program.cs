//Write a program that calculates with how many zeroes the factorial of a given number  n  has at its end.
//Your program should work well for very big numbers, e.g.  n=100000 .

using System;

class ZiroNumbers
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        int counter = 0;
        for (int i = 1; i <= n; i++)
        {
            int devider = i;
            if (devider % 5 == 0)
            {
                counter++;
                devider /= 5;
            }
        }
        Console.WriteLine(counter);

    }

}

