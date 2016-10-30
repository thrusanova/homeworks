//Write a program that reads from the console a sequence of  n  integer numbers and returns the minimal,
//the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number  n  (alone in a line) followed by  n  lines, each holding an integer number.
// The output is like in the examples below.

using System;
using System.Linq;

class MinMaxAverageSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var arr = new double[n];
        if (n > 0 && n < 1001)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
            }



            Console.WriteLine("min={0:F2}", arr.Min());
            Console.WriteLine("max={0:F2}", arr.Max());
            Console.WriteLine("sum={0:F2}", arr.Sum());
            Console.WriteLine("avg={0:F2}", arr.Average());
        }

    }
}