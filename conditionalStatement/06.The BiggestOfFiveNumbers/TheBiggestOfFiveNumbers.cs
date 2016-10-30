//Write a program that finds the biggest of five numbers by using only five if statements.
using System;
class TheBiggestFiveNumbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());
        double numberOne = Math.Max(a, b);
        double numberTwo = Math.Max(c, d);
        double numberThree = Math.Max(numberTwo, e);
        double number = Math.Max(numberThree, numberOne);
        Console.WriteLine(number);
    }
}
