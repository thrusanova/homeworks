﻿//Write an if-statement that takes two double variables a and b and exchanges their values if 
//the first one is greater than the second one. As a result print the values a and b, separated by a space.
using System;
class ExchangeIfGreater
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c;
        if (a > b)
        {
            c = b;
            b = a;
            a = c;
        }
        Console.WriteLine("{0} {1}",a,b );
       
    }
}
