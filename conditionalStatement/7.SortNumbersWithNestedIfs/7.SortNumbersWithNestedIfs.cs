//Write a program that enters 3 real numbers and prints them sorted in descending order. 
//abc,acb,cba,bac
using System;
class SortNumbersWithNestedIfs
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if ((a > b) && (a > c))
        {
            if (b > c)
            {
                Console.WriteLine(a + " " + b + " " + c);
            }
            else if (b <= c)
            {
                Console.WriteLine(a + " " + c + " " + b);
            }
        }
        else  if ((b > a) && (b > c))
        {
            if (a > c)
            {
                Console.WriteLine(b + " " + a + " " + c);
            }
            else if (a <= c)
            {
                Console.WriteLine(b + " " + c + " " + a);
            }
        }
        else if ((c > a) && (c > b))
        {
            if (a > b)
            {
                Console.WriteLine(c + " " + a + " " + b);
            }
            else if (a <= b)
            {
                Console.WriteLine(c + " " + b + " " + a);
            }
        }
        else if ((a == b) && (a == c))
        {

            Console.WriteLine(c + " " + b + " " + a);
        }
    }
}